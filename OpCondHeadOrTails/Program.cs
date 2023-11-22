var rand = new Random();
var value = (rand.Next(0, 2) == 0) ? "head" : "tails";
Console.WriteLine(value);