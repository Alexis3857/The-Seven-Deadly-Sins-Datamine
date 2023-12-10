# The Seven Deadly Sins Datamine
 
Program to download and exports new update's assets of the japanese version of The Seven Deadly Sins Grand Cross


## Usage

Get the current decryption key of the game with [The Seven Deadly Sins Key Finder](https://github.com/Alexis3857/The-Seven-Deadly-Sins-Key-Finder).

Run the program and pass the decryption key as an argument :
```cmd
7dsgcDatamine.exe -game=game -key=decryption_key -patch=patch_relative_sub:patch_version -write_changed_string
```

-game is mandatory
It's the game version to datamine, it must be either JP, KR or GB

-key is mandatory
It's the AES decryption passphrase, hidden in the game code and this program can not run without it.

-patch is optional
patch_relative_sub is the patch name, it changes every week when there's an update.
patch_version changes when a bug is fixed in a patch.
If no patch is given, the program will use the current game patch.

-write_changed_string is optional
If used, the program will also write strings that got changed and not only new strings.

Example if you want to export the assets from the latest JP update :
```cmd
7dsgcDatamine.exe -game=JP -key=WfcpJydk4-U_Zdyr5jaxFskH1ewy5b5y
```

If you want to export the assets from the KR game patch _fteaksskrhqlp version 3490 :
```cmd
7dsgcDatamine.exe -game=KR -key=WfcpJydk4-U_Zdyr5jaxFskH1ewy5b5y -patch=_fteaksskrhqlp:3490
```

If you missed a patch there is no way to know its name.

Using the current decryption key on an old patch isn't going to work, you need to pass the key that was being used by the game when the patch was issued.

If it's your first time running the program, it will download the necessary files for it to work for the followings updates.
If it's not your first time running the program, it will compare the new game version with the last version saved on your computer and export images, models, sounds and the database.


## Build

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