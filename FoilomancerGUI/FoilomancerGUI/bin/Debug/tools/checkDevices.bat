@echo off
adb start-server
adb devices | findstr /r /c:"device$" > nul
if errorlevel 1 (
    echo No devices
) else (
    echo Devices found:
    adb devices
)
