!define PRODUCT_NAME "DeRange"
!define PRODUCT_VERSION "v1.0"

Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"

RequestExecutionLevel admin
OutFile "${PRODUCT_NAME}.exe"
CRCCheck on
InstallDir "$PROGRAMFILES\Bright Silence Ltd\DeRange"
SetCompressor /SOLID bzip2

;Get installation folder from registry if available
InstallDirRegKey HKCU "Software\Bright Silence Ltd\DeRange" "InstallDir"

!include "MUI2.nsh"
!include "DotNetChecker.nsh"

; Modern UI Config

  ; Show a warning when the user cancels the install
  !define MUI_ABORTWARNING
  !define MUI_FINISHPAGE_NOAUTOCLOSE
  !define MUI_FINISHPAGE_RUN "$INSTDIR\DeRange.exe"
  !define MUI_FINISHPAGE_SHOWREADME
  !define MUI_FINISHPAGE_SHOWREADME_TEXT "Run at startup"
  !define MUI_FINISHPAGE_SHOWREADME_FUNCTION AddToStartup
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

  WriteRegStr HKCU "Software\Bright Silence Ltd\DeRange" "InstallDir" "$INSTDIR"
  WriteRegStr HKCU "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}" "DisplayName" "DeRange"
  WriteRegStr HKCU "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}" "UninstallString" '"$INSTDIR\Uninstall.exe"'

  WriteUninstaller "$INSTDIR\Uninstall.exe"
SectionEnd

Section "Uninstall"
  Delete "$INSTDIR\Uninstall.exe"
  Delete "$INSTDIR\DeRange.exe"
  Delete "$INSTDIR\DeRange.exe.config"
  Delete "$INSTDIR\LICENSE.rtf"
  Delete "$INSTDIR\Win32Interop.WinHandles.dll"

  RMDir "$INSTDIR"

  DeleteRegKey   HKCU "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
  DeleteRegKey   HKCU "Software\Bright Silence Ltd\DeRange"
  DeleteRegValue HKCU "SOFTWARE\Microsoft\Windows\CurrentVersion\Run" "DeRange"
SectionEnd

Function AddToStartup
   WriteRegStr HKCU "Software\Microsoft\Windows\CurrentVersion\Run" "DeRange" '"$INSTDIR\DeRange.exe"'
FunctionEnd

Function .onInit
 
  ReadRegStr $R0 HKCU \
  "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}" \
  "UninstallString"
  StrCmp $R0 "" done
 
  MessageBox MB_OKCANCEL|MB_ICONEXCLAMATION \
  "${PRODUCT_NAME} is already installed. $\n$\nClick `OK` to remove the \
  previous version or `Cancel` to cancel this upgrade." \
  IDOK uninst
  Abort
 
;Run the uninstaller
uninst:
  ClearErrors
  ReadRegStr $R1 HKCU "Software\Bright Silence Ltd\DeRange" "InstallDir"
  ExecWait '$R0'
 
  IfErrors no_remove_uninstaller done
    ;You can either use Delete /REBOOTOK in the uninstaller or add some code
    ;here to remove the uninstaller. Use a registry key to check
    ;whether the user has chosen to uninstall. If you are using an uninstaller
    ;components page, make sure all sections are uninstalled.
  no_remove_uninstaller:
 
done:
 
FunctionEnd
