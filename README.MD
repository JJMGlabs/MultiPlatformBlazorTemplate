# Blazor Multi-Platform App Template

This project is a simple template based on the Blazor framework templates from Microsoft that allows multiple versions of the same project via shared class library. It is intended that the code be altered and copied into your own projects depending on your needs.

## Using the Template

The quickest way to get started is to open the solution in visual studio and change the name of each project manually. Following the below steps this can be done very quickly, though it is a good idea to change each project one at a time, then ensure the solution still builds correctly.

- Find and replace all occurrences of the projects name across the entire solution. I normally do this with visual studio code from the root of the repo (where this README is located) to avoid missing any values.
- Ensure the folder and .csproj file for the project is renamed from the File Explorer (these are usually missed by find and replace operations
- There may now be references to the old folder paths that need to be found and replaced with the new path. Again, find and replace all references to the old folder path
- The entire solution should build and run successfully. You should also run the project to ensure it still renders correctly (In some cases a rebuild or even restart of Visual Studio is needed)
- Do for all projects you intend to use. Delete any project you don’t need excluding the shared library.

When you have the project set up as you prefer you can then move the solution folder into your own project ensuring not to take the .git folder or this Readme. This will allow you to unlink from this repository and use the template in your own project.

## Possible future plans

-   I may eventually create a Visual Studio template or similar to make the setup of the project less manual in future. 
-   It might be a good idea to have web app support by creating an api from shared.
