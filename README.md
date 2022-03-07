# CSharp-Projects

A collection of C# projects or tasks.

Location where project was found will be referenced at top of the .cs file in a comment.

Sources:
- https://csharpexercises.com/

## Check Brackets Sequence
I started this out by breaking down the problem into the necessary steps. My steps are very explicit. I looked at the solution and Lo! what a creative solution! I played around with that one and posted that as v2. I liked that I checked for whether all the characters were the opening or closing bracket, and I wanted to leave it in v2... but then I realized that with the way v2 is incrementing the `check` variable, it was already accomplishing that! (If there is no `(` then it would always subtact 1, leaving the condition `check == 0` to be false.) How cool.

## Add Separator
I had a bit of difficulty on this one, mostly relating to the fact that my initial strategy was to loop through the String as an array of chars, but then inserting it after each position became uncertain - do I change the char to a string along with the delimiter? If so, then I can't use an index position of a char array to hold that two character string any longer. Or do double the length, spreading out the existing characters to every other one, then loop and then insert? At this juncture, I started looking through the methods in the [String class](https://docs.microsoft.com/en-us/dotnet/api/system.string?view=net-6.0), especially the methods `Concat()`, `Insert()`, `Join()`, `Replace()`, and `Split()`. I did end up looking over the offered solution but not so in depth as to copy it exactly, only to get a narrower jumping off point. 
