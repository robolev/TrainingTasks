using System.Security.Cryptography;

namespace TrainingTasks;

public class Arrays
{
    public void Main(string[] args)
    {
       // Console.WriteLine(Array1(9));
       // Console.WriteLine(Array2(9));
       // Console.WriteLine(Array3(9,5,10));
       // Console.WriteLine(Array4(2,2,10));
       // Console.WriteLine(Array5(10));
       // Console.WriteLine(Array6(10,2,2));
       // Console.WriteLine(Array7(new []{1,2,3,4,5,6,8,9,10}));
       // Console.WriteLine(Array8(new []{1,2,3,4,5,6,8,9,10}));
       // Console.WriteLine(Array9(new []{1,2,3,4,5,6,8,9,10}));
       // Console.WriteLine(Array10(new []{1,2,3,4,5,6,8,9,10}));
    }

    static string Array1(int n)
    { 
        int[] oddNumbers = new int[n];
        for (int i = 0, num = 1; i < n; i++, num += 2)
        {
            oddNumbers[i] = num;
        }
        return string.Join(", ", oddNumbers);
    }

    static string Array2(int n)
    {
        int[] powersOfTwo = new int[n];
        int powerOfTwo = 2;
        for (int i = 0; i < n; i++)
        {
            powersOfTwo[i] = powerOfTwo;
            powerOfTwo *= 2;
        }
        return string.Join(", ", powersOfTwo);
    }

    static string Array3(int a,int d,int n)
    {
        int[] arithmeticsProgression = new int[n];
        for (int i = 0; i < n; i++)
        {
            arithmeticsProgression[i] = a + (i * d);
        }
        return string.Join(", ", arithmeticsProgression);
    }

    static string Array4(int a,int d,int n)
    {
        int[] progression = new int[n];
        int currentTerm = a;

        for (int i = 0; i < n; i++)
        {
            progression[i] = currentTerm;
            currentTerm *= d;
        }

        return string.Join(", ", progression);
    }

    static string Array5(int n)
    {
        int[] fibonacci = new int[n];
        
        fibonacci[0] = 1;
        fibonacci[1] = 1;
        
        for (int i = 2; i < n; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

        return string.Join(", ", fibonacci);
    }

    static string Array6(int n,int a ,int b)
    {
        int[] arr = new int[n];
        int sum = 0;
        arr[0] = a;
        arr[1] = b;
        
        for (int i = 2; i < n; i++)
        {
            arr[i] += arr[i - 1] + arr[i - 2];
        }
        return  string.Join(", ", arr);
    }

    static string Array7(int[] numbers)
    {
        Array.Reverse(numbers);
        return string.Join(", ", numbers);
    }
    
    static string Array8(int[] numbers)
    {
        List<int> oddNumbersList = new List<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 != 0)
            {
                oddNumbersList.Add(numbers[i]);
            }
        }
        
        return $"[{string.Join(", ", oddNumbersList)}], K = {oddNumbersList.Count}";
    }
    
    static string Array9(int[] numbers)
    {
        Array.Reverse(numbers);
        List<int> evenNumbersList = new List<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                evenNumbersList.Add(numbers[i]);
            }
        }
        
        return $"[{string.Join(", ", evenNumbersList)}], K = {evenNumbersList.Count}";
    }
    
    static string Array10(int[] numbers)
    {
      
        List<int> evenNumbers = new List<int>();
        List<int> oddNumbers = new List<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                evenNumbers.Add(numbers[i]);
            }
            else
            {
                oddNumbers.Add(numbers[i]);
            }
        }

        evenNumbers.Sort();
        oddNumbers.Reverse();

        List<int> result = new List<int>(evenNumbers);
        result.AddRange(oddNumbers);

        return string.Join(", ", result);
    }
}