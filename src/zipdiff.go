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

// get file list from both zips DONE
// find added files in mod
// find removed files in mod
// find changed files in mod
// generate another zip with all the new files and changed files, and put a [filename].remove where stuff should be removed
func listFiles(zipPath string) map[string]string {
	var filelist map[string]string = make(map[string]string)
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
			filelist[fname] = calculateMD5(fileContent)
		}
	}
	return filelist
}
func getAdded() {

}
func getRemoved() {

}
func getChanged() {

}
func CreatePatch() {

}
func generateRemovedPlaceholders() {

}

func calculateMD5(data []byte) string {
	hasher := md5.New()
	hasher.Write(data)
	return hex.EncodeToString(hasher.Sum(nil))
}
func zipdiff(old string, new string, output string) {

}
