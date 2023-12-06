//using System.Linq;

var lines = File.ReadAllLines("input.txt");

int sum = 0;

foreach (var line in lines)
{
    string num1 = line.Where(Char.IsAsciiDigit).First().ToString();
    string num2 = line.Where(Char.IsAsciiDigit).Last().ToString();
    string num = num1 + "" + num2;
    sum += int.Parse(num);
}


Console.WriteLine(sum);

string[] words = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
string[] nums  = {"0o", "o1e", "t2o", "3e", "4", "5e", "6", "7", "8", "9e"};

sum = 0;
foreach (var line in lines)
{

    string newLine = line;
    for (int i = 0; i < words.Length; i++)
    {
        if (newLine.Contains(words[i]))
        {
            newLine = newLine.Replace(words[i], nums[i]);
        }    
    }

    string num1 = newLine.Where(Char.IsAsciiDigit).First().ToString();
    string num2 = newLine.Where(Char.IsAsciiDigit).Last().ToString();
    string num = num1 + "" + num2;

    sum += int.Parse(num);
}

Console.WriteLine(sum);
