# LINQ and Lambdas

[Docs](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-operator)

- LINQ (Language-Integrated Query) is a combination of C# features and .NET classes that helps you work with sequences of data.

- METHOD CHAINING:
    Method chaining is a common way of making multiple method calls in a row. It isn't unique to LINQ, you cau use it in your own classes.
    Almost all of the LINQ methods return an `IEnumerable<T>`, you can take the result of a LINQ
    method and call another LINQ method directly on them with using a variable to keep track of the results.

## LINQ's query syntax

- LINQ queries work on sequences or objects that implement `IEnumerable<T>`

- LINQ declarative query syntax uses special keywords where, select, groupby, and join,to build queries directly into your code.

```csharp
// Example 1

int[] values = new int[] {0, 12, 44, 36, 92, 54, 13, 8};
IEnumerable<int> result = from v in values where v < 37 orderby -v select v;
```

- LINQ queries are built from clauses, in Example 1 we have four.
  - Clause #1: `from v in values`
    - The from clause assigns a variable, called the range variable, to stand in for each value as it iterates through the array. In the above example, in the first iteration the variable v is 0, then 12, etc.
  - Clause #2: `where v < 37`
    - A `where` clause contains a conditional test that the query uses to determin which values to include in the results, in this example, any value less than 37.
  - Clause #3: `orderby -v`
    - An orderby clause contains an expression used to sort the results, `-v` sorts from highest to lowest.
  - Clause #4: `select v`
    - A select clause tells the query what to put in the results.

# MISC

- A property is a class member that looks like a filed when it's used, but acts like a method when it runs.
- References are like labels, you can move labels but it's the object that dictates what methods and data are available.
- When you use the `static` keyword to declare a field or method in a class, you don't need an instance of that class to access it.
- When a field is static there's only one copy of it, and it's shared by all instances.