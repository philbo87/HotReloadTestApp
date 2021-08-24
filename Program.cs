// See https://aka.ms/new-console-template for more information

while (true)
{
    Console.WriteLine("Press a key");
    var key = Console.ReadLine();
    if (key == null) continue;
    if (key.Equals("Y"))
    {
        Console.WriteLine("You pressed Y");
    }
    else
    {
        Console.WriteLine("You pressed another key");
    }
}