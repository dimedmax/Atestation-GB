﻿string[] inputArray = { "111", "2", "333333", ":-)" };

        
        string[] resultArray = FilterStrings(inputArray);
        
        Console.WriteLine("Результат:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }