[Setup]
AppName=WindowsTitleChanger
AppVersion=0.1
DefaultDirName={pf}\WindowsTitleChanger
DefaultGroupName=WindowsTitleChanger
UninstallDisplayIcon={app}\WindowsTitleChanger.exe
Compression=lzma2
SolidCompression=yes
OutputDir=iss_output
OutputBaseFilename=WindowsTitleChanger
ArchitecturesAllowed=x64
ArchitecturesInstallIn64BitMode=x64
SetupIconFile="app.ico"
PrivilegesRequired=admin

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; \
    GroupDescription: "{cm:AdditionalIcons}";

[Files]
Source: "bin\Release\netcoreapp2.0\netcoreapp2.0\win10-x64\publish\*.*"; DestDir: "{app}";

[Icons]
Name: "{group}\WindowsTitleChanger"; Filename: "{app}\WindowsTitleChanger.exe"; WorkingDir: "{app}"; IconFilename: "{app}\app.ico";
Name: "{commondesktop}\WindowsTitleChanger"; Filename: "{app}\WindowsTitleChanger.exe"; Tasks: desktopicon; IconFilename: "{app}\app.ico";
