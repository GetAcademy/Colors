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
        //
   // Summary:
   //     The color black.
   Black = 0,
   //
   // Summary:
   //     The color dark blue.
   DarkBlue = 1,
   //
   // Summary:
   //     The color dark green.
   DarkGreen = 2,
   //
   // Summary:
   //     The color dark cyan (dark blue-green).
   DarkCyan = 3,
   //
   // Summary:
   //     The color dark red.
   DarkRed = 4,
   //
   // Summary:
   //     The color dark magenta (dark purplish-red).
   DarkMagenta = 5,
   //
   // Summary:
   //     The color dark yellow (ochre).
   DarkYellow = 6,
   //
   // Summary:
   //     The color gray.
   Gray = 7,
   //
   // Summary:
   //     The color dark gray.
   DarkGray = 8,
   //
   // Summary:
   //     The color blue.
   Blue = 9,
   //
   // Summary:
   //     The color green.
   Green = 10,
   //
   // Summary:
   //     The color cyan (blue-green).
   Cyan = 11,
   //
   // Summary:
   //     The color red.
   Red = 12,
   //
   // Summary:
   //     The color magenta (purplish-red).
   Magenta = 13,
   //
   // Summary:
   //     The color yellow.
   Yellow = 14,
   //
   // Summary:
   //     The color white.
   White = 15 
 */