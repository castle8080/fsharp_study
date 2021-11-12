# fsharp_study

I will be participating in a study group about F#. We will be using Expert F# 4.0 as the base.

## Book / Reference Material

[Expert F# 4.0](https://link.springer.com/book/10.1007/978-1-4842-0740-6?utm_medium=affiliate&utm_source=commission_junction&CJEVENT=25654b34436911ec81945df20a1c0e13&utm_campaign=3_nsn6445_brand_PID9069228&utm_content=de_textlink&?utm_medium=affiliate&utm_term=PID9069228)

[F# Language Reference](https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/)

## Install Notes

[Install Instructions](https://docs.microsoft.com/en-us/dotnet/fsharp/get-started/install-fsharp#install-f-with-visual-studio-code)

[.Net SDK 6.0](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-6.0.100-windows-x64-installer)

Following the instructions to install visual studio code and add the Ionide-fsharp extension.

## Getting Started

https://docs.microsoft.com/en-us/dotnet/fsharp/get-started/get-started-vscode

Command Line To Create Project and Run

```
dotnet new console -lang "F#" -o getting_started
cd getting_started
dotnet build
dotnet run
```

Using interactive F# console:

https://docs.microsoft.com/en-us/dotnet/fsharp/tools/fsharp-interactive/

```
C:\Users\bryan\projects\fsharp_study\getting_started>dotnet fsi

Microsoft (R) F# Interactive version 12.0.0.0 for F# 6.0
Copyright (c) Microsoft Corporation. All Rights Reserved.

For help type #help;;

> 1 + 2;;
val it: int = 3

>
```

Writing bits of F# can also be done using notebooks:
https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.dotnet-interactive-vscode

I think I am going to use this as the first demo for the study group and advocate for using:
* Visual Studio Code
* .Net Interactive

While going through the chapters.

## First Session

In the first session will mostly be an introduction, share what brought them to the study group,
what do they expect to get out of it. We will talk about the book and go over a quick demo
using F# with .Net interactive in visual studio code. We will also set a timeline to go through
chapter 2.