
# react-native-lib-vlc

## Getting started

`$ npm install react-native-lib-vlc --save`

### Mostly automatic installation

`$ react-native link react-native-lib-vlc`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-lib-vlc` and add `RNLibVlc.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNLibVlc.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNLibVlcPackage;` to the imports at the top of the file
  - Add `new RNLibVlcPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-lib-vlc'
  	project(':react-native-lib-vlc').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-lib-vlc/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-lib-vlc')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNLibVlc.sln` in `node_modules/react-native-lib-vlc/windows/RNLibVlc.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Lib.Vlc.RNLibVlc;` to the usings at the top of the file
  - Add `new RNLibVlcPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNLibVlc from 'react-native-lib-vlc';

// TODO: What to do with the module?
RNLibVlc;
```
  