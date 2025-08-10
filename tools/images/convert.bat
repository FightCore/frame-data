@echo off
setlocal

if "%~1"=="" (
    echo Please drag and drop an animated PNG file onto this script.
    pause
    exit /b
)

set "INPUT=%~1"
set "BASENAME=%~n1"

echo Converting %INPUT% to WebM...
ffmpeg -y -r 25 -i "%INPUT%" "%BASENAME%.webm"

echo.
echo Done!
pause
endlocal
