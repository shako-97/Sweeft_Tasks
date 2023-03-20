using Tasks.Sweeft.App;
using Tasks.Sweeft.EFCore;
using Tasks.Sweeft.EFCore.Models;
using Tasks.Sweeft.CountriesAPI;

// Task 1
string text = "aabaa";
if (Exercises.IsPalindrome(text))
    Console.WriteLine($"{text} is palindrome");
else
    Console.WriteLine($"{text} is not palindrome");

// Task 2
int num = 86;
Console.WriteLine($"The Minimum split count for {num} is {Exercises.MinSplit(num)}");

// Task 3
int[] array = { 4, 2, 1, 8, 9, 20 };
Console.WriteLine($"The Minimum number that array does not contains is {Exercises.NotContains(array)}");

// Task 4
if (Exercises.IsPalindrome("()))(("))
    Console.WriteLine("The brackets mathematically is correct");
else
    Console.WriteLine("The brackets mathematically is wrong");

// Task 5
int stears = 3;
Console.WriteLine($"The number of variants for climbing {stears} floor is {Exercises.CountVariants(stears)}");

// Task 7
Teacher[] teachers = DbHelper.GetAllTeachersByStudent("Giorgi");

foreach (var item in teachers)
    Console.WriteLine($"{item.FirstName}, {item.LastName}, {item.Gender}, {item.Subject}");

// Task 8
RestService restService = new("https://restcountries.com");
var countries = await restService.GetCountries("/v3.1/all");
FileHelper.WriteCountriesInFile(countries);