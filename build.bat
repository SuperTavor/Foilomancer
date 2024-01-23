@echo off
go build
move foilomancer.exe bin/foilomancer.exe
copy dependencies/xdelta.dll bin/xdelta.dll
copy dependencies/foilomancer.keystore bin/foilomancer.keystore