@echo off
cls
setlocal

set resGenPath=%ProgramFiles(x86)%\Microsoft SDKs\Windows\v7.0A\Bin\ResGen.exe
set installationPath=%ProgramFiles%\ClearCanvas\ClearCanvas DICOM Viewer
set /p installationPath=Enter the ClearCanvas Workstation or DicomViewer installation directory [%installationPath%]: 
echo.
pushd %installationPath%
if exist "%resGenPath%" (
  "%resGenPath%" "%~dp0\source\SR.resx"
)
"%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\csc.exe" /nologo ^
/target:library ^
/reference:.\common\ClearCanvas.Common.dll ^
/reference:.\plugins\ClearCanvas.Dicom.dll ^
/reference:.\plugins\ClearCanvas.Desktop.dll ^
/reference:.\plugins\ClearCanvas.ImageViewer.dll ^
/out:.\plugins\Econmed.ImageViewer.Layout.ExplodeImageBoxesTool.dll ^
/resource:"%~dp0\source\SR.resources",Econmed.ImageViewer.Layout.SR.resources ^
/resource:"%~dp0\source\Icons\ExplodeImageBoxLarge.png",Econmed.ImageViewer.Layout.Icons.ExplodeImageBoxLarge.png ^
/resource:"%~dp0\source\Icons\ExplodeImageBoxMedium.png",Econmed.ImageViewer.Layout.Icons.ExplodeImageBoxMedium.png ^
/resource:"%~dp0\source\Icons\ExplodeImageBoxToolSmall.png",Econmed.ImageViewer.Layout.Icons.ExplodeImageBoxToolSmall.png ^
"%~dp0\source\*.cs"
popd
echo.
if errorlevel 1 (
  echo Installation of ExplodeImageBoxesTool plugin failed.
) else (
  echo Installation of ExplodeImageBoxesTool plugin successfully done.
)
pause>NUL
endlocal
