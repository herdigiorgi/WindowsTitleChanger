[Setup]
AppName=TitleChanger
AppVersion=0.1
DefaultDirName={pf}\TitleChanger
DefaultGroupName=TitleChanger
UninstallDisplayIcon={app}\TitleChanger.exe
Compression=lzma2
SolidCompression=yes
OutputDir=iss_output
OutputBaseFilename=title_changer
ArchitecturesAllowed=x64
ArchitecturesInstallIn64BitMode=x64

[Files]
Source: "bin\Release\netcoreapp2.0\netcoreapp2.0\win10-x64\publish\*.*"; DestDir: "{app}";

[Icons]
Name: "{group}\TitleChanger"; Filename: "{app}\TitleChanger.exe"
