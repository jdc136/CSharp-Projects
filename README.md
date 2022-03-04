# CSharp-Projects

A collection of C# projects or tasks.

Location where project was found will be referenced at top of the .cs file in a comment.

Sources:
- https://csharpexercises.com/

## Check Brackets Sequence
I started this out by breaking down the problem into the necessary steps. My steps are very explicit. I looked at the solution and Lo! what a creative solution! I played around with that one and posted that as v2. I liked that I checked for whether all the characters were the opening or closing bracket, and I wanted to leave it in v2... but then I realized that with the way v2 is incrementing the `check` variable, it was already accomplishing that! (If there is no `(` then it would always subtact 1, leaving the condition `check == 0` to be false.)
