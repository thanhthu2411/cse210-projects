// See https://aka.ms/new-console-template for more information

// string x = "Thu";
// string firstFriend = "Maria";
// decimal a = 42.89;
// float b = 32.5;

// Console.WriteLine($"{x}");

int counter = 10;
do
{
    // Console.WriteLine(coutner);
    counter++;
} while (counter < 5);


// list
var names = new List<string> { "Thu", "Anna", "Felipe" };
names.Add("David");
names.Add("Damian");
Console.WriteLine(names[0]);
Console.WriteLine(names[^1]); // get the first element from the back
Console.WriteLine(names[^2]); // get the second element from the back

names.Sort();
Console.WriteLine($"I found Thu at index {names.IndexOf("Thu")}");
foreach (var name in names[2..4]) // names[2..4] get elements with index 2 and 3 (index 2 is included, but index 4 is not)
{
    Console.WriteLine(name);
}


// array
var members = new string[] { "Son", "Daughter", "Mom", "Dad", "Grandpa" };
// u cannot use .Add in an array because its length is fixed.
members = [.. members, "Grandma"];

foreach (var mem in members)
{
    Console.WriteLine(mem);
}


//LINQ
List<int> scores = [97, 93, 38, 81, 50];

IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    select score;

foreach (int i in scoreQuery)
{
    Console.Write(i + " ");
}