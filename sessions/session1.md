# Plan For First Study Session

In the first session for the group, there will be no recommended reading. The goal of
the first session will be to introduce ourselves, choose materials, choose tools, plan study sessions.

## 1. Books

The first choice for the group is to decide which materials to use. I looked at the following 3 books:

[Real World Functiona Programming](https://www.manning.com/books/real-world-functional-programming?query=real%20world%20functional%20programming)

* 2010
* Coverage of functional programming fundamentals
* Few exercises
* F# and C#


[Functional Programming Using F#](https://www.amazon.com/Functional-Programming-Using-Michael-Hansen-ebook-dp-B00CARIB52/dp/B00CARIB52/ref=mt_other?_encoding=UTF8&me=&qid=1636733852)

* 2013
* Lots of exercises
* Not as much coverage of history or benefits of functional programming
* F#

[Expert F# 4.0](https://link.springer.com/book/10.1007/978-1-4842-0740-6?utm_medium=affiliate&utm_source=commission_junction&CJEVENT=25654b34436911ec81945df20a1c0e13&utm_campaign=3_nsn6445_brand_PID9069228&utm_content=de_textlink&?utm_medium=affiliate&utm_term=PID9069228)

* More recent
* Seems to get more into using F# as a tool without a narrow focus on FP
    * FP is discussed in 1 chapter

I am leaning towards Real World Functional Progrmaming. I like the discussion of FP and the history. I think it gives reasons why
FP is important. There aren't as many exercises.

We can take exercises though using 99 problems. There is a translation of the original 99 problems (Prolog) to OCaml which is very
close to F#.

[OCAML 99 Problems](https://ocaml.org/learn/tutorials/99problems.html)

## 2. Tools

We will go over the tools that we can use for study.

<b><u>.Net Core</u></b>

We will be going through samples using .Net core with the latest SDK.

[.Net SDK 6.0](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-6.0.100-windows-x64-installer)


<b><u>Visual Studio Code</u></b>

We will mainly use visual studio code for the sessions.

[Visual Studio Code](https://code.visualstudio.com/)

There are instructions for installing F# tools for visual studio code.

[VSCode F Sharp Tool Installation](https://docs.microsoft.com/en-us/dotnet/fsharp/get-started/install-fsharp#install-f-with-visual-studio-code)

<b><u>.Net Interactive</u></b>

We will go through sample code using .Net Interactive, which is basically a local version of Jupyter running inside VSCode that supports languages such as F#.

[.Net Interactive](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.dotnet-interactive-vscode)

## 3. Demo Tools

### 3.1 F# Project Command Line

```
dotnet new console -lang "F#" -o getting_started
cd getting_started
dotnet build
dotnet run
```

### 3.2 Command Line F# Interactive

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

### 3.3 .Net Interactive Demo

We will show how how to use .Net Intractive to run examples from the first chapter
of Real World Functional Programming.

### 3.4 .Net Interactive From Jupyter

Create a python virtual environment to install jupyter. This step is only needed once. This requires an installation of Python. This probably won't be used for most of the group, but I thought it would be interesting to
show.

```
python -mvenv venv
```

Activate the environment. You will have to do this if you open a new terminal or prompt.

```
venv\Script\Activate
```

Install packages to run Jupyter

```
pip install jupyterlab
```

Next we will be following instructions from:

https://github.com/dotnet/interactive/blob/main/docs/NotebookswithJupyter.md

Check what kernels are installed in Jupyter.

```
(venv) C:\Users\bryan\projects\fsharp_study>jupyter kernelspec list
Available kernels:
  python3
```


Install .Net interactive

```
dotnet tool install -g --add-source "https://pkgs.dev.azure.com/dnceng/public/_packaging/dotnet-tools/nuget/v3/index.json" Microsoft.dotnet-interactive
```

Install Jupyter Kernel for .Net Interactive

```
dotnet interactive jupyter install
```

You should now see more kernels:

```
(venv) C:\Users\bryan\projects\fsharp_study>jupyter kernelspec list
Available kernels:
  .net-csharp        C:\Users\bryan\AppData\Roaming\jupyter\kernels\.net-csharp
  .net-fsharp        C:\Users\bryan\AppData\Roaming\jupyter\kernels\.net-fsharp
  .net-powershell    C:\Users\bryan\AppData\Roaming\jupyter\kernels\.net-powershell
  python3
```

Launch jupyter


```
jupyter lab
```



