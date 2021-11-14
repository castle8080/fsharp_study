# fsharp_study

I will be participating in a study group about F#.
## Books

The group needs to consider which book or other resources to use. I looked at expert F# first.
This book is newer, but does not get into the fundamentals of functional programming as much
as I had hoped. It seems more foccussed on being useful with F#.

Real World Functional Programming seems to cover functional programming core concepts, but I
didn't see exercises in the book. The book has more discussion about the merits and reasons
for functional progrmaming in the first chapter. I am leaning towards using this book.

I am looking at Functional Programming Using F#. It looks like it covers functional programming
core concepts + coding exercises. But not as much discussino about the merits of functional progrmaming.

[Real World Functional Programming](https://www.manning.com/books/real-world-functional-programming?query=real%20world%20functional%20programming)

[Functional Programming Using F#](https://www.amazon.com/Functional-Programming-Using-Michael-Hansen-ebook-dp-B00CARIB52/dp/B00CARIB52/ref=mt_other?_encoding=UTF8&me=&qid=1636733852)

[Expert F# 4.0](https://link.springer.com/book/10.1007/978-1-4842-0740-6?utm_medium=affiliate&utm_source=commission_junction&CJEVENT=25654b34436911ec81945df20a1c0e13&utm_campaign=3_nsn6445_brand_PID9069228&utm_content=de_textlink&?utm_medium=affiliate&utm_term=PID9069228)

## Reference Material

[F# Language Reference](https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/)

## Install Notes

[Install Instructions](https://docs.microsoft.com/en-us/dotnet/fsharp/get-started/install-fsharp#install-f-with-visual-studio-code)

[.Net SDK 6.0](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-6.0.100-windows-x64-installer)

Following the instructions to install visual studio code and add the Ionide-fsharp extension.


We will be using .Net Interactive during our study sessions. This gives a notebook style interface in VSCode to execute F# code.

[.Net Interactive](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.dotnet-interactive-vscode)


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


## First Session

First session agenda:

1. Discuss book to use.
2. Demo visual studio code and using command line to create and run F# project.
3. Demo and show using .Net Interactive with chapter 1 samples.

