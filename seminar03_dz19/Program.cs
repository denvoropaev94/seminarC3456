﻿Console.WriteLine("Введите пятизначное число");
string str = Console.ReadLine();
string newstr = "";

string InversionString (string str)
{
    for (int i = str.Length - 1; i >= 0; i--)
    {
        newstr += str[i];
    }
    return newstr;
}
bool IsPolindrom(string str){
    
    string res = InversionString(str);
        if (res==str){
            return true;
        }
        else{
            return false;
        }
    }   
bool result = IsPolindrom(str);
Console.WriteLine(result);



