# The Seven Deadly Sins Datamine
 
Program to download and exports new update's assets of the game The Seven Deadly Sins Grand Cross


## Usage

Get the current decryption key of the game with [The Seven Deadly Sins Key Finder](https://github.com/Alexis3857/The-Seven-Deadly-Sins-Key-Finder).
Run the program and pass the decryption key as an argument, example :
```cmd
7dsgcDatamine.exe 86C-vWbZEs-HIVqoZMt03DIYoUBQLTrg
```
If it's your first time running the bot it will download the necessary files for it to work for the followings updates.
If it's not your first time running the bot it will compare the new game version with the last version saved on your computer by the bot and export images, models, sounds and the database.


## Requirements

Open the 7dsgcDatamine.csproj in Visual Studio.

Download [AssetStudio dlls](https://github.com/K0lb3/AssetStudio/releases/download/test-onrelease9/AssetStudioUtility.net6.0.Windows.x64.zip) (windows x64).

Create a folder dll in the same folder than 7dsgcDatamine.csproj and paste in those dlls :
	-AssetStudio.dll
	-AssetStudio.PInvoke.dll
	-AssetStudioFBXWrapper.dll
	-AssetStudioUtility.dll
	-K4os.Compression.LZ4.dll
	-Mono.Cecil.dll
	-Mono.Cecil.Mdb.dll
	-Mono.Cecil.Pdb.dll
	-Mono.Cecil.Rocks.dll
	-SixLabors.Fonts.dll
	-SixLabors.ImageSharp.dll
	-SixLabors.ImageSharp.Drawing.dll
	-Texture2DDecoderWrapper.dll

Then use them as references in the project.

Intall the NuGet packages :
	-Microsoft.Data.Sqlite
	-Newtonsoft.Json
	-ServiceStack.Text

Compile.

In the executable directory paste the dlls :
	-AssetStudioFBXNative.dll
	-fmod.dll
	-Texture2DDecoderNative.dll