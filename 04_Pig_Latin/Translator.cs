using System;

namespace _04_Pig_Latin
{
    internal class Translator
    {
        internal string Translate(string pig)
        {
            string[] words = pig.Split(' ');
            string result = "";
            for (int i = 0; i < words.Length; i++ )
            {
                if (words[i].Substring(0,1).ToLower() == "a" || words[i].Substring(0,1).ToLower() == "e" || words[i].Substring(0, 1).ToLower() == "i" || words[i].Substring(0, 1).ToLower() == "o" || words[i].Substring(0, 1).ToLower() == "u" || words[i].Substring(0, 1).ToLower() == "y")
                {
                    result += pig + "ay";
                }
                else {
                    result += words[i].Substring(1) + words[i].Substring(0,1) + "ay";
                }
            }
            return result; 
        }
    }
}