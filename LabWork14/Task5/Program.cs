using System.Text.RegularExpressions;

string input = "23/12/2024";
string pattern = @"(0[1-9]|[12][0-9]|3[01])[/](0[1-9]|1[012])[/]((19|20)*\d\d)";
string replacement = "$3-$2-$1";
string result = Regex.Replace(input, pattern, replacement);
Console.WriteLine(result);