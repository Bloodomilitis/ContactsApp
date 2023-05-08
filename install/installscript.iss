[Setup]
AppName=ContactsApp
AppVersion=1.0
WizardStyle=modern
DefaultDirName="{autopf}\Kalashnikov Kirill\ContactsApp"
DefaultGroupName=ContactsApp
UninstallDisplayIcon="{app}\ContactsApp.exe"
Compression=lzma2
SolidCompression=yes
OutputDir=Output
[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; \
    GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
[Files]
Source: "..\src\ContactsApp\ContactsApp.View\bin\Release\*.dll"; DestDir: "{app}"
Source: "..\src\ContactsApp\ContactsApp.View\bin\Release\ContactsApp.exe"; DestDir: "{app}"
[Icons]
Name: "{group}\{cm:UninstallProgram,ContactsApp}"; Filename: "{uninstallexe}"; IconFilename: "{app}\ContactsApp.exe"
Name: "{group}\ContactsApp"; Filename: "{app}\ContactsApp.exe";
Name: "{userdesktop}\ContactsApp"; Filename: "{app}\ContactsApp.exe"; \
    Tasks: desktopicon
