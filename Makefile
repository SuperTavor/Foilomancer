.PHONY: all

all: foilomancer

foilomancer:
	cd src && go build -o ../bin/foilomancer.exe
	copy xdelta.dll bin\xdelta.dll
	copy foilomancer.keystore bin\foilomancer.keystore
	mkdir bin\game_dump
