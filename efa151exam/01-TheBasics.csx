//Part One: The Basics
//1.Declare and initialize 5 different types.Int, Boolean, String, Double, Decimal
//2.Write a function that takes two of your variables from #1 and combines two or more of them into a string. For instance:
//I have been happily married to Esther for 14 years.
//3.Print the string to the console.
//4.Create an array of strings, a simple array of 3-5 names of your closest friends or family will suffice.
//5.Loop over the array and print it to the console.

using System;
using System.Collections.Generic;

//1. Declare and initialize 5 different types:
int i = 20;
bool b = true;
string s = "Angela";
double dbl = 20.30d;
decimal d = 20.3m;

//2.Write a function that takes two of your variables from #1 and combines two or more of them into a string. For instance:
//"I have been happily married to Esther for 14 years."
//3.Print the string to the console.

void happilyMarried(string happilyMarried)
{
    Console.WriteLine("I have been married to {spouseName} for {years}");
}

var spouseName = "Angela Lurton";
var years = "20";

//4.Create an array of strings, a simple array of 3-5 names of your closest friends or family will suffice.
//5.Loop over the array and print it to the console.

var myFriends = new string[3];
    myFriends[0] = "Angela";
    myFriends[1] = "Chad";
    myFriends[2] = "Mike";

Console.WriteLine(myFriends[0]);
Console.WriteLine(myFriends[1]);
Console.WriteLine(myFriends[2]);


