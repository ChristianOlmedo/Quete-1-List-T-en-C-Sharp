using System.IO;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> list = new List<string>();
        list.Add("god");
        list.Add("boa");
        list.Add("bed");
        Console.WriteLine("Oh my " + list[0] + " ! There is a " + list[1] +
        " under my " + list[2] + " !");
        list.RemoveAt(0);
        list.Remove("bed");
        Console.WriteLine("Oh my god ! There is a " + list[0] +
        " under my bed !");
    }
}
