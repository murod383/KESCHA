﻿System.Console.Write("Hello, Enter your name: ");
string name = Console.ReadLine();
string greeting = $"Hello {name}, let`s calulate you age and others age.";

System.Console.Write("Enter your age please:");
string ageAsString = Console.ReadLine();
System.Console.WriteLine("Consverting....");
int age = Convert.ToInt32(ageAsString);
System.Console.WriteLine($"Succesfully converted your age is {age}");
int ageKescha = 10;
int ageDifference = age - ageKescha;
System.Console.WriteLine($"The difference between you and kescha`s age is {ageDifference}");