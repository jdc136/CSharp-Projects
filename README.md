# CSharp-Projects

A collection of C# projects or tasks.

Location where project was found will be referenced at top of the .cs file in a comment.

Sources:
- https://csharpexercises.com/
- http://imranontech.com/2007/01/24/using-fizzbuzz-to-find-developers-who-grok-coding/

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

## Sum Digits in String
Once again, I found this pretty straightforward and got it done in about 5-10 minutes. I did have to remind myself that `int.TryParse()` requires a second argument with the `out` keyword.

## Make Uppercase
I learned a number of new things on this one. First, I initially struggled with making every other letter uppercase when looping through the string *as a string*. So after a little research, I changed what I was looping through to a character array and then returned that as a string. On this, I initially used `ToString()` which I discovered "returns the default textual representation of a type instance" (Albahari and Albahari 101). Instead I used `new string(char array)` which as I understand it creates an instance of that character array as a string, as opposed to returning the "default textual representation", which for a reference type will be what amounts to a description.

## Mix Two Strings
I was really pleased with my learning and problem-solving experience on this one. It was in that sweet spot of challenging, but not too challenging. The easy part was getting two strings of equal length to mix. The hard part was when you had two strings of unequal length, particularly when the first string was longer than the second string. Initially, I briefly thought a nested for loop would be helpful but then I realized that would not work because that would mean for *every* character in the first string, I want to go through all the characters in the second string. I realized that the strings of variable lengths needed to be added together on the same loop iteration, but one may not always be able to add a character from the current loop iteration if that string's length was less than the current iteration loop. So instead I started playing around with `if` statements of various configurations. It got fairly complex fast, and I thought this has to be simpler. So I wrote out a pseudo-code and gained clarity on what conditions I needed to check for. This resulted in two very simple if-statements which simply checked whether the current iteration of the loop was less than the number of characters in the string. I had to finesse how I was checking this due to 0-based indexing. Satisfying experience solving this one!

## Number of Words
This one almost seemed mis-classified as 'intermediate'. I solved it handily, only having to tweak fringe cases a bit like an empty string (zero words) or a single word sentence (one word).

## Revert Words Order
This was a challenging one! I got a reversal of the sentence pretty quick, as defined by delimiting on a space, but handling the punctuation was the pesky part. In my solution you can see what I did, but with the input `A, B. C` I wasn't getting the expected `C B. A,`. I tried a number of things but after realizing the crux of the issue with my code, I decided to look at the solution code. I went through it all, and then realized that didn't provide the expected output either! So I've gone ahead and just posted the solution code commmented out below my own solution.

## Sort Characters Descending
This one is either be very easy or very hard! I looked up the methods for Array class and simply did `Array.Sort()` and then `Array.Reverse()` which got me exactly the results I wanted. However, because the whole point of this is to go through an algorithm myself, I took a shot at sorting in descending order... and boy is there a lot out there about sorting! I do want to revisit this one in the future, but for now, it was satisfactory to look over numerous algorithms (notably quicksort) that would solve the problem of sorting each character in this array.

## Compress String
I wrote this out in about 15 minutes, expecting it to be much harder given that it was classified as "hard". I was a bit dissatisfied with my code because I repeat a line, but upon looking at the offered solution, we had done very nearly the same thing. And it works!

## Elementary Dear Watson
This Elementary Operations exercise was pretty staightforward. Most difficult thing was converting the string input to int, which I had forgotten! I assummed that the order the digits were entered was the order in which the digits should be applied to each other by the various operators (i.e. second number is the divisor). (Note, this only really matters for subtraction and division, as there are mathematical laws stating the result of multiplication and addition will not be affected by the arguments.) Though it did take me longer than I would have liked, I was pleased at how I broke the problem up eventually into the two methods.

## Bibliography
Albahari, Joseph and Ben Albahari. *C# 9.0 Pocket Reference: Instant Help for C# 9.0 Programmers*. O'Reilly Media, 2021.
