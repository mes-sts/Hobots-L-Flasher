@echo off

:ADMIN

if /I "%PROCESSOR_ARCHITECTURE%"=="AMD64" goto AMD64
if /I "%PROCESSOR_ARCHITEW6432%"=="AMD64" goto AMD64

dpinst_x86.exe
goto END

:AMD64
dpinst_amd64.exe

:END