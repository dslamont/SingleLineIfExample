Console.WriteLine("");
Console.WriteLine("Single Line 'if' Statement");
Console.WriteLine("");

string condition1 = "Some random text";
Console.WriteLine($"condition1 = {condition1}");

if (condition1 != null)
{
    Console.WriteLine($"This line should only appear if 'condition1; is not null.");
}

Console.WriteLine("");
Console.WriteLine("");