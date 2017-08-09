!define PRODUCT_NAME "DeRange"
!define PRODUCT_VERSION "v1.0"

Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"

RequestExecutionLevel admin
OutFile "${PRODUCT_NAME}.exe"
CRCCheck on
InstallDir "$PROGRAMFILES\Bright Silence Ltd\DeRange"
SetCompressor /SOLID bzip2

;Get installation folder from registry if available
 InstallDirRegKey HKCU "Software\Bright Silence Ltd\DeRange" ""

!include "MUI2.nsh"
!include "DotNetChecker.nsh"

; Modern UI Config

  ; Show a warning when the user cancels the install
  !define MUI_ABORTWARNING
  !define MUI_FINISHPAGE_NOAUTOCLOSE

;--------------------------------
;Pages
 
  !insertmacro MUI_PAGE_WELCOME
  !insertmacro MUI_PAGE_LICENSE "..\LICENSE"
  !insertmacro MUI_PAGE_DIRECTORY
  !insertmacro MUI_PAGE_INSTFILES
  !insertmacro MUI_PAGE_FINISH ; the Finish page

  !insertmacro MUI_UNPAGE_WELCOME
  !insertmacro MUI_UNPAGE_CONFIRM
  !insertmacro MUI_UNPAGE_INSTFILES
  !insertmacro MUI_UNPAGE_FINISH

  ;--------------------------------
;Languages
 
  !insertmacro MUI_LANGUAGE "English"

   ;General

;Installer Sections     
Section "Install"
  SetOutPath "$INSTDIR"

  !insertmacro CheckNetFramework 45

  File "..\DeRange\bin\Debug\DeRange.exe"
  File "..\DeRange\bin\Debug\DeRange.exe.config"
  File "..\LICENSE.rtf"
  File "..\DeRange\bin\Debug\Win32Interop.WinHandles.dll"

  CreateShortCut "$SMPROGRAMS\${PRODUCT_NAME}\${PRODUCT_NAME}.lnk" "$INSTDIR\DeRange.exe" "" "$INSTDIR\DeRange.exe" 0

  WriteUninstaller "$INSTDIR\Uninstall.exe"
SectionEnd

Section "Uninstall"
  Delete "$INSTDIR\Uninstall.exe"
  Delete "$INSTDIR\DeRange.exe"
  Delete "$INSTDIR\DeRange.exe.config"
  Delete "$INSTDIR\LICENSE.rtf"
  Delete "$INSTDIR\Win32Interop.WinHandles.dll"

  RMDir "$INSTDIR"

  DeleteRegKey /ifempty HKCU "Software\Bright Silence Ltd\DeRange"
  DeleteRegValue HKCU "SOFTWARE\Microsoft\Windows\CurrentVersion\Run" "DeRange"
SectionEnd