# CSharp-Projects

A collection of C# projects or tasks.

Location where project was found will be referenced at top of the .cs file in a comment.

Sources:
- https://csharpexercises.com/

## Check Brackets Sequence
I started this out by breaking down the problem into the necessary steps. My steps are very explicit. I looked at the solution and Lo! what a creative solution! I played around with that one and posted that as v2. I liked that I checked for whether all the characters were the opening or closing bracket, and I wanted to leave it in v2... but then I realized that with the way v2 is incrementing the `check` variable, it was already accomplishing that! (If there is no `(` then it would always subtact 1, leaving the condition `check == 0` to be false.) How cool.

## Add Separator
I had a bit of difficulty on this one, mostly relating to the fact that my initial strategy was to loop through the String as an array of chars, but then inserting it after each position became uncertain - do I change the char to a string along with the delimiter? If so, then I can't use an index position of a char array to hold that two character string any longer. Or do double the length, spreading out the existing characters to every other one, then loop and then insert? At this juncture, I started looking through the methods in the [String class](https://docs.microsoft.com/en-us/dotnet/api/system.string?view=net-6.0), especially the methods `Concat()`, `Insert()`, `Join()`, `Replace()`, and `Split()`. I did end up looking over the offered solution but not so in depth as to copy it exactly, only to get a narrower jumping off point. After looking it over once, I was able to come up with the approach of adding the string to itself in a new variable for each iteration of the loop.

## Is Palindrome
At this point, I've gone over a couple algorithms testing whether a word is a palindrome a few times, so I found this to be straightforward. I didn't remember in detail what I had done before, but playing around with a couple strategies I was able to solve it in about 10-15 minutes.

## Length of String
This one was easiest by far! I got it in about 5 minutes, simply using a `foreach` loop to go through each character in the string, including spaces. I didn't call any library methods or properties at all, including `String.Length`.

## Reverse String
Like Length of String, I found this one to be very simple and straightforward. Mostly because of work from the Is Palindrome and Add Separator exercises.
