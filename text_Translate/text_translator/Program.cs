using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Pig LatinTranslator");
        Console.WriteLine();

        Console.Write("Enter Word:  ");
        string word = Console.ReadLine();

        //Step One
        int vowelPosition = -1;
        foreach (char letter in word)
        {
            vowelPosition = vowelPosition + 1;
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                break;
            }
        }
        //Step Two
        string pigLatinWord = "";
        string beforeLetters = "";
        string afterLetters = "";

        switch (vowelPosition)
        {
            case 0:
                pigLatinWord = word + "way";
                break;
            case 1:
                beforeLetters = word.Substring(0, 1);
                afterLetters = word.Substring(1);
                pigLatinWord = afterLetters + beforeLetters + "ay";
                break;
            case 2:
                beforeLetters = word.Substring(0, 2);
                afterLetters = word.Substring(2);
                pigLatinWord = afterLetters + beforeLetters + "ay";
                break;
            default:
                pigLatinWord = "unable to translate this word, am Sorry!";
                break;
        }
        Console.WriteLine("Translation: " + pigLatinWord);
        Console.WriteLine();
        Console.WriteLine("-----Press any key to exit this buffer");
        Console.ReadKey();
    }
}