string[] inputArray = { "111", "2", "333333", ":-)" };

        
        string[] resultArray = FilterStrings(inputArray);

        Console.WriteLine("Результат:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }

static string[] FilterStrings(string[] inputArray)
    {
        int count = 0; 
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }

        string[] resultArray = new string[count];
        int index = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                resultArray[index] = inputArray[i];
                index++;
            }
        }
        return resultArray;
    }
       