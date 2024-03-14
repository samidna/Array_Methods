
//int[] nums = { 1, 2, 3, -5, -8 };

//Console.WriteLine(Methods.Factorial(5));

//Methods.Fibonacci(5);

//int[] tempArr = Methods.MakePositive(nums);
//Console.WriteLine(string.Join(",",nums));

string word = "    Garage Academy   ";
Console.WriteLine(Methods.ClearSpaces(word));



//int[] newArr = Methods.AddData(nums, 4);
//Console.WriteLine(string.Join(", ", newArr));
class Methods
{
    // TASK-1
    public static int[] AddData(int[] array, int num)
    {
        int[] tempArray = new int[array.Length+1];

        for (int i = 0; i < array.Length; i++)
        {
            tempArray[i]=array[i];
        }

        tempArray[array.Length]=num;

        return tempArray;
    }

    // TASK-2

    public static string ClearSpaces(string word)
    {
        string tempWord = "";
        int right = 0;
        int left = 0;
        for (int i = word.Length-1; i>=0; i--)
        {
            if (word[i] == ' ' && i != 0)
            {
                right++;
                if (word[i-1] != ' ') break;
            }
            else
            {
                break;
            }
        }
        for (int i = 0; i<word.Length; i++)
        {
            if (word[i] == ' ' && i != word.Length-1)
            {
                left++;
                if (word[i+1] != ' ') break;
            }
            else
            {
                break;
            }
        }
        for (int i = left; i < word.Length-right; i++)
        {
            tempWord += word[i];
        }
        return tempWord;
    }

    // TASK-3

    public static int[] MakePositive(int[] array)
    {
        for (int i = 0; i<array.Length; i++)
        {
            if (array[i]<0) array[i] *= -1;
        }
        return array;
    }

    // TASK-4

    public static int Factorial(int num)
    {
        if (num==0) return 1;
        return num * Factorial(num-1);
    }

    // TASK-5

    public static void Fibonacci(int num)
    {
        int a = 0;
        int b = 1;
        Console.WriteLine(a);
        Console.WriteLine(b);
        for (int i = 0; i<num; i++)
        {
            int c = a+b;
            a=b;
            b=c;
            Console.WriteLine(c);
        }
    }
}
