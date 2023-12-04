var color = ConsoleColor.DarkGreen;

while (true)
{
    Console.BackgroundColor = color;
    Console.ForegroundColor = (ConsoleColor)(15 - (int)color);

    Console.Clear();
    Console.WriteLine("Farge: " + color);
    Console.WriteLine("Hva vil du gjøre? ");
    Console.WriteLine(" 1 = gå fra mørk til lys");
    Console.WriteLine(" 2 = gå fra lys til mørk");
    Console.WriteLine(" 3 = inverter ");
    Console.WriteLine(" 4 = neste ");
    Console.WriteLine(" 5 = forrige ");

    var cmd = Console.ReadLine();
    if (cmd == "1")
    {
        var colorName = color.ToString();
        if (colorName.Contains("Dark"))
        {
            colorName = colorName.Substring(4);
            color = Enum.Parse<ConsoleColor>(colorName);
        }
    }
    else if (cmd == "2")
    {
        var colorName = color.ToString();
        colorName = "Dark" + colorName;
        var isSuccess = ConsoleColor.TryParse(colorName, out color);
    }
    else if (cmd == "3")
    {
        var colorNumber = (int)color;
        colorNumber = 15 - colorNumber;
        color = (ConsoleColor)colorNumber;
    }
    else if (cmd == "4")
    {
        color++;
    }
    else if (cmd == "5")
    {
        color--;
    }
}

/*
   Black = 0,
   DarkBlue = 1,
   DarkGreen = 2,
   DarkCyan = 3,
   DarkRed = 4,
   DarkMagenta = 5,
   DarkYellow = 6,
   Gray = 7,
   DarkGray = 8,
   Blue = 9,
   Green = 10,
   Cyan = 11,
   Red = 12,
   Magenta = 13,
   Yellow = 14,
   White = 15 
 */