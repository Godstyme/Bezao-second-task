using System;
using System.Collections.Generic;
public class TextTranslation
{
    public static void pig_latin(string originalText)
    {
        List<String> newText = new List<String>();
        string[] words = originalText.Split(' ');
        string addedText = "ay";
        foreach (string word in words){
                string fisrtCharacter = word.Substring(0,1);
                string remainingString = word.Remove(0,1);
                string lastResult = $"{remainingString}{fisrtCharacter}{addedText}";
                    newText.Add(lastResult);
        }
        string pigLatin = string.Join(" ", newText);
        Console.WriteLine(pigLatin);
    }



    public static void pig_latin_english(string originalText)
    {
        string[] words = originalText.Split(' ');
        List<String> newText = new List<String>();
        foreach (string word in words){
                string lastTwoCharacter = word.Remove(word.Length - 2);
                char lastCharacter = lastTwoCharacter[lastTwoCharacter.Length-1];
                string lastCharResult = lastTwoCharacter.Remove(lastTwoCharacter.Length - 1);
                string stringResult = $"{lastCharacter}{lastCharResult}";
                    newText.Add(stringResult);
        }
        string englishString = string.Join(" ", newText);
        Console.WriteLine(englishString);
    }
    public static void Main(string[] args)
    {
        pig_latin("The quick brown fox");
        pig_latin_english("heTay uickqay rownbay oxfay");
    }
}