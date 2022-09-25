# Blazor Multi-Platform App Template

This project is a simple template based on the Blazor framework templates from Microsoft that allows multiple versions of the same project via shared class library. It is intended that the code be altered and copied into your own projects depending on your needs.

## Using the Template

The quickest way to get started is to open the solution in visual studio and change the name of each project manually. This is currently not automated however by following the below steps can be done very quickly.

-   Open the solution file inside the BlazorMultiPlatformTemplate folder of the repo in Visual Studio 2022 (You may need to be using the Visual Studio preview version for the latest MAUI features)
-   Now select a project you intend to rename and ensure you copy its name to the clipboard CTRL+C.
-   Right click or press F2 on a project to rename it. Using the Shared Library as an example, we can rename it as “MyProjectSharedLibrary”.
-   We now need to search the entire solution and replace its usages of the old project name. One way this can be done is by the following:
    -   Inside visual studio use the find all shortcut normally ctrl+shift+F
    -   Paste the original project name (“SharedLibrary”) as the value to find
    -   Switch to the “Replace in Files” tab and enter the new project name as the replace value “MyProjectSharedLibrary” click replace all (Ensure you replace all for the entire solution)
-   Rename project folder in file explorer
-   Reimport to Visual Studio (it will be removed after the previous step). To do this:
    -   Delete the now broken project (MyProjectSharedLibrary) from Visual Studio Solution Explorer (You may need to restart Visual Studio
    -   Right click the solution in Solution Explorer-\>Add-\>Add Existing Project-\>Choose the renamed project

Do for all projects needed. Delete any project you don’t need excluding the shared library.

When you have the project set up as you prefer it you can then move the solution folder into your own project ensuring not to take the .git folder. This will allow you to unlink from this repository and use the template in your own project.

## Possible future plans

-   I may eventually create a Visual Studio template or similar to make the setup of the project less manual.
-   It might be a good idea to have a web app support by creating an api from shared for web to connect to
