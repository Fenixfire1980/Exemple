﻿

string text = "- Я думая, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwerty"            
          //  012345 
//s[3] // r          

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int Length = text.Length;
    for (int i = 0; i < Length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }


    return result;
}

string newText = Replase(text,' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'с', 'С');
Console.WriteLine(newText);

