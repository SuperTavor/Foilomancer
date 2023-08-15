@echo off
setlocal

set "package=jp.co.level5.yws1"
set "outputDir=cache"

if exist "%outputDir%" (
    rmdir /s /q "%outputDir%"
)

mkdir "%outputDir%"

for /f "tokens=1,* delims=:" %%a in ('adb shell pm list packages -f ^| findstr /i /c:"%package%"') do (
    set "apkPath=%%b"
    setlocal enabledelayedexpansion
    set "apkPath=!apkPath:~1!"
    set "apkPath=!apkPath:/=\!"
    
    for %%c in ("!apkPath!") do (
        for /r %%d in ("%%~dpnc\*.apk") do (
            echo Pulling: "%%~d"
            adb pull "%%~d" "%outputDir%"
        )
    )
    
    endlocal
)

echo All split APKs associated with %package% have been extracted to %outputDir%

pause
