package main

import (
	"fmt"
	"os"
	"os/exec"
	"strings"

	"github.com/mholt/archiver/v3"
	"github.com/spf13/afero"
)

var fs afero.Fs = afero.NewOsFs()

func containsValue(slice []string, valueToFind string) bool {
	for _, v := range slice {
		if v == valueToFind {
			return true
		}
	}
	return false
}

func main() {
	//testmain()
	if len(os.Args) < 2 {
		fmt.Println("Foilomancer version 1.0.0\n------------\nto pack a mod: foilomancer create [modded game dump path]\nto load a mod:foilomancer load [foil file] ")
		os.Exit(1)
	}
	if os.Args[1] == "create" {
		create()
	} else if os.Args[1] == "load" {
		load()

	} else {
		fmt.Println("Please make sure that your args follow this template: foilomancer create [modded game dump path]")
	}
}
func testmain() {
	GetFiles("test.zip", &vanillaList)
	for k, v := range vanillaList {
		fmt.Println(k, v)
	}
	os.Exit(1)
}
func load() {
	//check cmdargs
	if len(os.Args) != 3 {
		fmt.Println("Please make sure that your args follow this template: foilomancer load [foil file]")
		os.Exit(1)
	}
	//check for vanilla apk dump
	gamedump_files := getGameDump()
	var s_gamedump_files []string
	for _, file := range gamedump_files {
		s_gamedump_files = append(s_gamedump_files, file.Name())
	}
	checkForVanillaApk()
	//create tmp path if it doesnt exist
	_, err := afero.ReadDir(fs, "tmp")
	if err != nil {
		fs.Mkdir("tmp", 0755)
	}
	//get path to foil file
	foil := os.Args[2]
	//open foil
	{
		err = new(archiver.Zip).Unarchive(foil, "tmp")
		if err != nil {
			fmt.Printf("Could not unpack provided foil file!\n\n%s\n", err)
			os.Exit(1)
		}
	}
	//get metadata
	if !fileExists("tmp/metadata.txt") {
		fmt.Printf("Could not read metadata: metadata file does not exist in foil.\n")
		cleanupCreate()
		os.Exit(1)
	}
	var metadata []string
	{
		content, err := os.ReadFile("tmp/metadata.txt")
		if err != nil {
			fmt.Printf("Could not read metadata: %s\n", err)
			cleanupCreate()
			os.Exit(1)
		}
		metadata = strings.Split(string(content), "\n")
	}
	var modname string = metadata[0]
	var modver string = metadata[1]
	var author string = metadata[2]
	//present mod data and ask to proceed in installation
	fmt.Printf("----Installation----\nMod name: %s\nMod version: %s\nAuthor:%s\n--------------------\nDo you wish to install this mod? (y/n)\n", modname, modver, author)
	var isContinue string
	fmt.Scanln(&isContinue)
	if strings.Trim(isContinue, " ") != "y" {
		fmt.Println("Cancelling operation and cleaning up.")
		cleanupCreate()
		os.Exit(0)
	}
	//find corresponding files in vanilla apk dump
	var files_in_foil []string
	{
		tmpfiles, err := afero.ReadDir(fs, "tmp")
		if err != nil {
			fmt.Println("Error reading directory:", err)
			os.Exit(1)
		}
		for _, file := range tmpfiles {
			if file.Name() != "metadata.txt" {
				files_in_foil = append(files_in_foil, file.Name())
			}
		}
	}
	var mutuals []string
	for _, file := range files_in_foil {
		if containsValue(s_gamedump_files, file) {
			mutuals = append(mutuals, file)
		}
	}

	//patch the files that are present in the foil file
	for _, mutual := range mutuals {
		PatchXdelta("game_dump/"+mutual, "tmp/"+mutual+".patch", "tmp/patched_"+mutual)
	}
	//sign them
	//apksigner sign --ks foilomancer.keystore --ks-pass pass:foilomancer --key-pass pass:foilomancer --out signed.apk base.apk
	for _, mutual := range mutuals {
		cmd := exec.Command("cmd.exe", "/C", "apksigner.bat", "sign", "--ks", "foilomancer.keystore", "--ks-pass", "pass:foilomancer", "--key-pass", "pass:foilomancer", "--out", "tmp/signed_"+mutual, "tmp/patched_"+mutual)
		_, err := cmd.CombinedOutput()
		if err != nil {
			fmt.Printf("Could not sign APK:%s\n", err)
			cleanupCreate()
			os.Exit(1)
		}
	}
	//load into the user's device
}
func CreateXdelta(oldf string, newf string, patchf string) {
	cmd := exec.Command("cmd.exe", "/C", "xdelta.dll", "-e", "-s", oldf, newf, patchf)
	_, err := cmd.CombinedOutput()
	if err != nil {
		fmt.Printf("Error creating patch from %s: %s", oldf, err)
		//fmt.Println("Output:", string(output))
		return
	}
}
func PatchXdelta(oldf string, patchf string, newf string) {
	cmd := exec.Command("cmd.exe", "/C", "xdelta.dll", "-d", "-s", oldf, patchf, newf)
	_, err := cmd.CombinedOutput()
	if err != nil {
		fmt.Printf("Error creating patch from %s: %s", oldf, err)
		cleanupCreate()
		os.Exit(1)
	}
}
func fileExists(file string) bool {
	exists, _ := afero.Exists(fs, file)
	return exists
}
func checkForVanillaApk() {
	gamedump := getGameDump()
	if len(gamedump) == 0 {
		fmt.Println("game_dump folder is empty. Please make sure you dumped all the files in the YKW 1 Mobile app package.")
		os.Exit(1)
	}
}
func getGameDump() []os.FileInfo {
	gamedump_files, gerr := afero.ReadDir(fs, "game_dump")
	if gerr != nil {
		fmt.Println("Error reading directory:", gerr)
		os.Exit(1)
	}
	return gamedump_files
}
func inputMd() [3]string {
	var md [3]string
	fmt.Println("What is your mod's name?")
	fmt.Scanln(&md[0])
	fmt.Println("What is your mod's version?")
	fmt.Scanln(&md[1])
	fmt.Println("What is your name? (mod author)")
	fmt.Scanln(&md[2])
	return md
}
func cleanupCreate() {
	terr := os.RemoveAll("tmp")
	if terr != nil {
		fmt.Printf("Could not delete temporary folder:%s\n", terr)
		os.Exit(1)
	}
}
func packFoil(mutuals *[]string, modname string) {
	var inzip []string
	inzip = append(inzip, "tmp/metadata.txt")
	for _, mutual := range *mutuals {
		inzip = append(inzip, "tmp/"+mutual+".patch")
	}
	zerr := archiver.Archive(inzip, "mod.zip")
	if zerr != nil {
		fmt.Printf("Could not create final foil file: %s\n", zerr)
		os.Exit(1)
	}
	rerr := fs.Rename("mod.zip", modname+".foil")
	if rerr != nil {
		fmt.Printf("Could not create final foil file: %s\n", rerr)
		os.Exit(1)
	}
}
func create() {
	//check cmdargs
	if len(os.Args) != 3 {
		fmt.Println("Please make sure that your args follow this template: foilomancer create [modded game dump path]")
		os.Exit(1)
	}
	//check for vanilla apk dump
	gamedump_files := getGameDump()
	checkForVanillaApk()
	//create tmp path if it doesnt exist
	_, err := afero.ReadDir(fs, "tmp")
	if err != nil {
		fs.Mkdir("tmp", 0755)
	}
	//store modded game dump path
	moddedGamePath := os.Args[2]
	//ask for metadata (modname,modversion,author)
	metadata := inputMd()
	modname := metadata[0]
	//write metadata to tmp folder
	s_metadata := fmt.Sprint(metadata[0], "\n", metadata[1], "\n", metadata[2])
	fileerr := os.WriteFile("tmp/metadata.txt", []byte(s_metadata), 0644)
	if fileerr != nil {
		fmt.Println("Error writing to file:", err)
		os.Exit(1)
	}
	//check what files are modified
	modded_files, merr := afero.ReadDir(fs, moddedGamePath)
	if merr != nil {
		fmt.Printf("Could not read your modded game dump folder (%s)\n", moddedGamePath)
		os.Exit(1)
	}
	//declare list of files present in both the modded file dump and the vanilla file dump
	var mutual_files []string
	//convert the game dump file slice to a string slice
	var game_dump_names []string
	for _, fname := range gamedump_files {
		game_dump_names = append(game_dump_names, fname.Name())
	}
	//setup mutual files slice
	for _, file := range modded_files {
		if containsValue(game_dump_names, file.Name()) {
			mutual_files = append(mutual_files, file.Name())
		}
	}
	// TODO Replace xdelta patching with zip content checking.
	//create xdelta patches for the modified files
	for _, mutual := range mutual_files {
		CreateXdelta("game_dump/"+mutual, moddedGamePath+"/"+mutual, "tmp/"+mutual+".patch")
	}
	//put that in a zip with metadata and name the zip [modname].foil
	packFoil(&mutual_files, modname)
	//remove temporary folder
	cleanupCreate()

	fmt.Printf("Finished packing %s! Enjoy \n", modname)
	os.Exit(0)
}
