# Why is my code not working?

Based on [this Microsoft learn module](https://docs.microsoft.com/en-us/learn/modules/dotnet-debug/)

## An Intro to Debugging

A debugger is a tool used to observer and control the execution flow of your program with an analytical approach. The primary benefit of using one is that you can *watch* your program running and even follow your program execution one line of code at a time.

- **Breakpoints** are used to pause the program at any statement during execution.
- **Conditional breakpoints*** allow you to enter a condition for breaking execution.
- **Variables** will be organized by scope:
  - **Local variables:** are accessible in the current scope (usually the current function).
  - **Global variables:** are accessible from everywhere in your program. System objects from the JavaScript runtime are also included, so don't be surprised if you see a lot of stuff in there.
  - **Closure variables:** are accessible from the current closure, if any. A closure combines the local scope of a function with the scope from the outer function it belongs to.
- **Watch variables**: allow you to track a variable across time or different functions.



