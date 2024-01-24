package main

import (
	"archive/zip"
	"crypto/md5"
	"encoding/hex"
	"fmt"
	"io"
	"os"
	"strings"
)

var vanillaList map[string]string = make(map[string]string)
var modList map[string]string = make(map[string]string)

// get file list from both zips DONE
// find added and changed files in mod
// find removed files in mod (post release)
// generate another zip with all the new files and changed files, and put a [filename].remove where stuff should be removed
func GetFiles(zipPath string, filelist *map[string]string) {
	r, err := zip.OpenReader(zipPath)
	if err != nil {
		fmt.Println("Error opening zip file:", err)
		cleanupCreate()
		os.Exit(1)
	}
	defer r.Close()

	for _, file := range r.File {
		if !strings.HasPrefix(file.Name, "META-INF") {
			fileReader, err := file.Open()
			if err != nil {
				fmt.Println("Error opening file within the zip:", err)
				cleanupCreate()
				os.Exit(1)
			}
			defer fileReader.Close()
			fileContent, err := io.ReadAll(fileReader)
			if err != nil {
				fmt.Println("Error reading file content:", err)
				cleanupCreate()
				os.Exit(1)
			}
			fname := file.Name
			(*filelist)[fname] = calculateMD5(fileContent)
		}
	}
}

// Gets added or changed files from the zip.
func getAddedChanged(og map[string]string, mod map[string]string) ([]string, []string) {
	var addedChanged []string
	var unchanged []string

	// find added or changed
	for key, modValue := range mod {
		if ogValue, exists := og[key]; exists {
			if modValue != ogValue {
				addedChanged = append(addedChanged, key)
			} else {
				unchanged = append(unchanged, key)
			}
		} else {
			addedChanged = append(addedChanged, key)
		}
	}

	return addedChanged, unchanged
}

// will do post launch
func getRemoved() {

}
func CreatePatch() {

}

// removed - post launch
func generateRemovedPlaceholders() {

}

func calculateMD5(data []byte) string {
	hasher := md5.New()
	hasher.Write(data)
	return hex.EncodeToString(hasher.Sum(nil))
}
func zipdiff(old string, new string, output string) {
	//get vanillaMap
	GetFiles(old, &vanillaList)
	//get modMap
	GetFiles(new, &modList)
	//get diffs
	diffs := getAddedChanged(vanillaList, modList)
	//extract the changed/added files from the modded zip
	//copy the vanilla zip
	//inject the extracted changed/added files into the vanilla zip copy
	//save the vanilla zip copy at the path in output
}
