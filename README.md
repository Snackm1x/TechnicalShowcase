# TechnicalShowcase

This is a C# console application that parses a JSON API for photo albums and displays them in the console. This application leverages the nuget package Newton JSON in order to download the JSON information from the API. The project then takes input commands from the console line and displays information/errors accordingly.

A release version of the application can be downloaded from https://drive.google.com/open?id=0B676zOSSbYg4WWY4LWhNc1o5YzQ

After downloading the zip folder to run the application do as follows:
  1) Unzip the contents of the zip
  2) Open Folder Technical Showcase where you unzipped the folder contents
  3) Right click on TechnicalShowcase.exe and run as administrator (may not work without admin depending on your Windows settings)
  4) If prompted with an unauthorized exe Windows message click "More Info" and "Run anyways"
  5) Follow instructions on command prompt to utilize application.

Otherwise you may download the code to your computer and launch the application using Visual Studio:
  1) Clone/Download Github Repo of TechnicalShowcase
  2) Open TechnicalShowcase.sln using Visual Studio
  3) Click F-5 or Start to debug the project TechnicalShowcase (should be setup as default launch application)
  4) Follow instructions on command prompt to utilize appplication.

In order to execute Unit tests included you may need to do the following:
  1) Verify the AlbumTest project has TechnicalShowcase listed as a dependancy (should be set up)
  2) Open Visual Studio Test Explorer Window
  3) Right click and run individual test, or select Run All to run all associated unit tests in project
