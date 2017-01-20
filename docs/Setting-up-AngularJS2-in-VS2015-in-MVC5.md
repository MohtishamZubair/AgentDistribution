#Setting up AngularJS2 in VS2015 in MVC5

Currently lots of articles are available on net. But none able to enable single setup to work on Angular2 + typescript in VS2015 community (Update 3). You've to run npm install & also npm start commands on command line to run the project and enable auto compile, as these commands do start Node.JS server (which is not required in VS2015) and also auto compiling option for typescript changes. This is very frustrating setup develop angular2 application with opening command prompt. And more distraction when your mvc5 based application is also not compile-able or build-able. 

In following walk through you will be able successfully work on Angular2 (using systemjs) without need to run above mention commands just run application in debugging mode (F5) or (Ctrl + F5) and your changes of Typescript files will be there in browser refresh (or you can enable BrowserLink in VS) and also MVC application build will be successful. Let's start it by following steps

- Install Typescript
- Install Node.Js & Npm
- Setup for Angular 2

Feel free to bypass above two steps if you already have installed typescript and npm on your system.

## Install Typescript

You need to first of all install Typescript, Node.js + npm (node package manager)

For Type Script you can install it from VS2015(Update 3)

Tools > Extensions ... 

![select extension from tools](https://github.com/MohtishamZubair/AgentDistribution/blob/master/src/wiki/SetNugetPackage.png)

then on open dialog select **online** option like ![select on line ](https://github.com/MohtishamZubair/AgentDistribution/blob/master/src/wiki/ExtensionsPackages2Online.png)

then type search box for typescript and in results latest typescript on this date 8 jan'17 it was TS version 2.0.6

![select on lastest TS ](https://github.com/MohtishamZubair/AgentDistribution/blob/master/src/wiki/ExtensionsPackages3Online.png)
Then select download and follow screen to install as screen guide you

![select on download TS ](https://github.com/MohtishamZubair/AgentDistribution/blob/master/src/wiki/ExtensionsPackages4Online.png)


After successful installation restart the Visual Studio. Now on Typescript will be enable in all projects. If you don't want to install it via VS2015 then you can go to [Typescript site](https://www.microsoft.com/en-us/download/details.aspx?id=48593) and install it from installer as well.


## Installing Node.js + npm

After that install Node.js + npm from [their site](https://nodejs.org/en/download/), in fact no need of node.js server as visual studio has its own debugging express server, however VS2015 needs npm to resolve dependencies mention in package.json file. Make sure you should be able to run node and npm commands from anywhere in  your system via command line i.e. node and npm exe should be added to your path variables. Plz follow instructions from their site carefully. 

Now you are all most ready for angular 2 setup in VS.

##  Setup for Angular 2

Add a Web project of MVC application without using any authentication. And run the application in browser. As you see the default page then performs following steps to setup AngularJS 2 + Typescript in your project.

Simply copy zip from [angular setup zip](https://github.com/MohtishamZubair/AgentDistribution/blob/master/AngularVS2015Setup/vs2015Angularjs2setup8jan0136PST.zip). This zip is prepared for VS2015 Community (update 3) for making changes in package.json & tsconfig.json from [angularjs2 github repository](https://github.com/angular/quickstart)

And unzip it on root of your project. Then include these folders and files in your project by right click on project name and select "include in project" option.

1. package.json ( contains dependencies and required angular2 modules along with their version, extracted from Angular2 repository)
2. systemjs.config.js
3. app [folder] containing two ts files

Mean while two files under Views folder also changes i.e. _layouts.cshtml and index.cshtml

No need to include any other files or folders like "node_modules", it should be generated automatically. Now press F5 to run application in debugging mode.

 That's it. Now refresh the browser you should see this message

### angular2 has been set!

As angular2 has been setup now no need to build the project or run separate npm start or install command from command prompt

## Note
- Try to run all installation using administrator privileges and also the VS2015.
- Node_modules folder should be generated automatically based on package.json file on root.
