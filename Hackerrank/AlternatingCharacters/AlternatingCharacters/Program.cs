﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the alternatingCharacters function below.
    static int alternatingCharacters(string s)
    {
        int count = 1;
        s.Aggregate((i, j) => checkAndUpdate(i, j, ref count));
        return s.Length - count;
    }

    static char checkAndUpdate(char first, char second,ref int counter)
    {
        if (first == second)
        {
            return first;
        }
        else
        {
            counter++;
            return second;
        }
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        TextWriter textWriter = new StreamWriter("OUTPUT_PATH", true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = alternatingCharacters(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
