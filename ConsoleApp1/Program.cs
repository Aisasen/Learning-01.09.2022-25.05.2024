using System;
using System.Globalization;

class Worker
{
    public string name="Vladimir";
    public string surname="Tarasov";
    public int rate=200;
    public int days=30;
    public void GetFullName ()
    {
        Console.WriteLine (name);
        Console.WriteLine (surname);
    }
    public void GetSalary ()
    {
        Console.WriteLine(rate*days);
    }
    static void Main()
    {
        Console.WriteLine(Worker.GetSalary());
    }
}

class MyString
{
    public static string Reverse (string text)
    {
        char[] chars = text.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    public string UcFirst (string text)
    {
        return char.ToUpper(text[0]) + text.Substring(1);
    }

    public string UcWords (string text)
    {
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string titleCase = textInfo.ToTitleCase(text);
        return titleCase;
    }
    static void Main()
    {
        Console.WriteLine(MyString.Reverse("Id not Ccecrated"));
    }
}

