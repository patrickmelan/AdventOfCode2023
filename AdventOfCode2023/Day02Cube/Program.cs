using System;
using static System.Reflection.Metadata.BlobBuilder;

var lines = File.ReadAllLines("input.txt");

void One()
{
    int sum = 0;

    foreach (var line in lines)
    {

        var game = int.Parse(line.Substring(5, line.IndexOf(":") - 5));

        var newLine1 = line.Replace(", ", ",");

        var newLine = newLine1.Replace("; ", ";");

        newLine = newLine.Substring(newLine.IndexOf(":") + 2);

        var bags = newLine.Split(';');

        int reds = 0, blues = 0, greens = 0;

        bool good = true;

        foreach (var item in bags)
        {
            var newItem = item.Split(',');

            foreach (var item2 in newItem)
            {
                if (item2.Contains("red"))
                {
                    reds += int.Parse(item2.Substring(0, item2.IndexOf(" ")));
                }
                else if (item2.Contains("blue"))
                {
                    blues += int.Parse(item2.Substring(0, item2.IndexOf(" ")));
                }
                else if (item2.Contains("green"))
                {
                    greens += int.Parse(item2.Substring(0, item2.IndexOf(" ")));
                }


            }

            if (reds > 12 || greens > 13 || blues > 14) { good = false; }

            reds = 0;
            blues = 0;
            greens = 0;
        }


        Console.WriteLine(line);
        Console.WriteLine(good + "\n\n");

        if (good) sum += game;

    }

    Console.WriteLine(sum);
}

void Two()
{
    int sum = 0;

    foreach (var line in lines)
    {

        var game = int.Parse(line.Substring(5, line.IndexOf(":") - 5));

        var newLine1 = line.Replace(", ", ",");

        var newLine = newLine1.Replace("; ", ";");

        newLine = newLine.Substring(newLine.IndexOf(":") + 2);

        var bags = newLine.Split(';');

        int redMax = 0, blueMax = 0, greenMax = 0;

        bool good = true;

        foreach (var item in bags)
        {
            var newItem = item.Split(',');

            foreach (var item2 in newItem)
            {
                if (item2.Contains("red") && int.Parse(item2.Substring(0, item2.IndexOf(" "))) > redMax)
                {
                    redMax = int.Parse(item2.Substring(0, item2.IndexOf(" ")));
                }
                else if (item2.Contains("blue") && int.Parse(item2.Substring(0, item2.IndexOf(" "))) > blueMax)
                {
                    blueMax = int.Parse(item2.Substring(0, item2.IndexOf(" ")));
                }
                else if (item2.Contains("green") && int.Parse(item2.Substring(0, item2.IndexOf(" "))) > greenMax)
                {
                    greenMax = int.Parse(item2.Substring(0, item2.IndexOf(" ")));
                }
            }
            

            
        }

        var product = redMax * blueMax * greenMax;
        sum += product;
        Console.WriteLine(line);
        Console.WriteLine("\n\n");
        Console.WriteLine(sum);

    }
}

One();
Two();
