<!-- Tanis Olesen 10/15/2021 -->
<!-- A guide on how to make a SpecFlow project on a command line -->
## Before we start
We want to have the DotNet SDK installed on our system, Downloads can be found here: [DotNet Download](https://dotnet.microsoft.com/download 'DotNet Download')

The commands I list below are designed for a bash shell, which uses a forward slash "/" for directory names. To get the commands to work on a Windows terminal, any directory spelling must use a back slash "\\".

## Create a Solution
To start we need to create a dotnet solution project:

```bash
> dotnet new sln -o "ProjectName"
```
This command will create a new directory called ProjectName to navigate to that new directory:

```bash
> cd ProjectName
```
Now that we have navigated to our solutions directory we can create our Class Library:

```bash
./ProjectName> dotnet new classlib -o "ClassLibrary"
```
And our Console Project

```bash
./ProjectName> dotnet new console -o "Console"
```
To create a SpecFlow project we first need to get the SpecFlow Template:

```bash
./ProjectName> dotnet new -i SpecFlow.Templates.DotNet
```
Now we can create the SpecFlow project

```bash
./ProjectName> dotnet new specflowproject --unittestprovider specflowplusrunner --framework net5.0 -o "SpecFlow"
```
We now need to tell our solution to include our three projects

```bash
./ProjectName> dotnet sln add ./ClassLibrary/ClassLibrary.csproj
```

```bash
./ProjectName> dotnet sln add ./SpecFlow/SpecFlow.csproj
```

```bash
./ProjectName> dotnet sln add ./Console/Console.csproj
```

Next we need to add a reference from our SpecFlow project to our ClassLibrary.
First we change our directory to our SpecFlow project

```bash
./ProjectName> cd SpecFlow
```
Now we can add our reference:

```bash
./ProjectName/SpecFlow> dotnet add reference ../ClassLibrary/ClassLibrary.csproj
```
Then change our current directory to our solution directory:

```bash
./ProjectName/SpecFlow> cd ..
```
Now we add a reference from our Console project to our ClassLibrary:

```bash
./ProjectName> cd Console
```

```bash
./ProjectName/Console> dotnet add reference ../ClassLibrary/ClassLibrary.csproj
```
And one again return to our solution Directory

```bash
./ProjectName/Console> cd ..
```
We now are able to compile our Project and run SpecFlow tests:

```bash
./ProjectName> dotnet test
```
