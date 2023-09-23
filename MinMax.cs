namespace TrainingTasks;

public class MinMax
{
    public void Main(string[] args)
    {
        (int, int)[] pairOfNum = new (int, int)[]
        {
            (3, 4), 
            (2, 5), 
            (6, 2), 
            (4, 4), 
            (1, 7)  
        };
       // Console.WriteLine(MinMax1(new int[]{5,2,3,4}));
       //  Console.WriteLine(MinMax2(pairOfNum));
       //  Console.WriteLine(MinMax3(pairOfNum));
       //  Console.WriteLine(MinMax4(new int[]{5,2,3,4}));
       //  Console.WriteLine(MinMax5(pairOfNum));
       //  Console.WriteLine(MinMax6(pairOfNum));
       //  Console.WriteLine(MinMax7(new int[]{5,2,3,4}));
       //  Console.WriteLine(MinMax8(new int[]{10,34,5,2}));
       //  Console.WriteLine(MinMax9(new int[]{10,4,5,34}));
       //  Console.WriteLine(MinMax10(new int[]{10,4,5,34}));
       //  Console.WriteLine(MinMax11(new int[]{10,4,5,34}));
       //  Console.WriteLine(MinMax12(new int[]{10,4,5,34}));
       //  Console.WriteLine(MinMax13(new int[]{10,4,5,34}));
       //  Console.WriteLine(MinMax14(new int[]{10,4,5,34,56,7,8,4,84,4},5));
       //  Console.WriteLine(MinMax15(new int[]{10,4,5,34,56,7,8,4,84,4},5,9));
    }

    static (int min,int max)MinMax1(int[] numbers)
    {
        return(numbers.Min(),numbers.Max());
    }
    
    static int MinMax2((int, int)[] rectangles)
    {
        int minArea = int.MaxValue; 

        foreach ((int a, int b) in rectangles)
        {
            int area = a * b; 

            if (area < minArea)
            {
                minArea = area; 
            }
        }

        return minArea;
    }
    
    static int MinMax3((int, int)[] rectangles)
    {
        int maxPerimeter = int.MinValue; 
        foreach ((int a, int b) in rectangles)
        {
            int perimeter = 2 * (a + b); 

            if (perimeter > maxPerimeter)
            {
                maxPerimeter = perimeter; 
            }
        }

        return maxPerimeter;
    }
    
    static int MinMax4(int[] numbers)
    {
        return(numbers.Min());
    }

    static int MinMax5((int, int)[] density)
    {
        int maxDensity = int.MinValue; 
        foreach ((int m, int v) in density)
        {
            int p = m/v; 

            if (p > maxDensity)
            {
                maxDensity = p; 
            }
        }

        return maxDensity;
    }
    
    static (int min,int max) MinMax6(int[] numbers)
    {
        int min = numbers[0];
        int minIndex = 0;
        int max = numbers[0];
        int maxIndex = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
                minIndex = i;
            }
            if (numbers[i] > max)
            {
                max = numbers[i];
                maxIndex = i;
            }
        }

        return (minIndex, maxIndex);
    }
    
    static (int max,int min) MinMax7(int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];
        int minIndex = 0;
        int maxIndex = 0;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
                minIndex = i;
            }
            else if (numbers[i] > max)
            {
                max = numbers[i];
                maxIndex = i;
            }
        }
        
        return (maxIndex, minIndex);
    }

    
    static (int firstMinIndex,int lastMinIndex) MinMax8(int[] numbers)
    {
        int min = numbers[0];
        int firstMinIndex = 0;
        int lastMinIndex = 0;
        int currentIndex = 0;

        foreach (int number in numbers)
        {
            if (number < min)
            {
                min = number;
                firstMinIndex = currentIndex;
            }
            else if (number == min)
            {
                lastMinIndex = currentIndex;
            }
            
            currentIndex++;
        }
        
        return (firstMinIndex, lastMinIndex);
    }

    static (int firstMax, int LastMax) MinMax9(int[] numbers)
    {
        int max = numbers[0];
        int firstMax = 0;
        int LastMax = 0;
        int currentIndex = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if(numbers[i] > max )
            {
                max = numbers[i];
                firstMax = i;
            }
            else if (numbers[i] == max)
            {
                LastMax =  i;
            }
            currentIndex++;
        }

        return (LastMax, firstMax);
    }
    
    static int  MinMax10(int[] numbers)
    {
        int min = numbers.Min();
        int max = numbers.Max();
        int count = 0;
        for (int i = 0; i <  numbers.Length; i++)
        {
            if (numbers[i] == max || numbers[i] == min)
            {
                count = i;
                break;
            }
        }
        
        return count;
    }
    
    static int MinMax11(int[] numbers)
    {
        int min = numbers.Min();
        int max = numbers.Max();
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == max || numbers[i] == min)
            {
                count = i;
                
            }
        }
        return count;
    }

    static int MinMax12(int[] numbers)
    {
        int min = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if(numbers[i] < min && numbers[i] > 0)
            {
                min = numbers[i];
            }
        }

        return min;
    }
    
    static int MinMax13(int[] numbers)
    {
        int max = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if(numbers[i] > max && numbers[i] % 2 != 0)
            {
                max = numbers[i];
            }
        }
        
        return max;
    }
    
    static int MinMax14(int[] numbers,int b)
    {
        int B = 5; 
        int minAboveB = int.MaxValue; 
        int minAboveBIndex = -1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > B && numbers[i] < minAboveB)
            {
                minAboveB = numbers[i];
            }
        }
        return minAboveB ;
    }
    
    static string MinMax15(int[] numbers,int b,int c)
    {
        int maxInRange = int.MinValue;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNumber = numbers[i];

            if (currentNumber >= b && currentNumber <= c && currentNumber > maxInRange)
            {
                maxInRange = currentNumber;
            }
        }
        return maxInRange == int.MinValue ?  "0 0" : maxInRange.ToString();
    }
}