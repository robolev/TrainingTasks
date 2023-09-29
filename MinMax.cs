using System.ComponentModel.Design;

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
       //  Console.WriteLine(MinMax16(new int[]{23,4,5,6,7,2}));
       //  Console.WriteLine(MinMax17(new int[]{2,4,5,63,7,2}));
       //  Console.WriteLine(MinMax18(new int[]{10,4,5,5,6,63}));
       //  Console.WriteLine(MinMax19(new int[]{10,4,4,5,6,63}));
       //  Console.WriteLine(MinMax20(new int[]{10,4,4,4,5,6,63}));
       //  Console.WriteLine(MinMax21(new int[]{10,6,3,4,7,5,89,63}));
       //  Console.WriteLine(MinMax22(new int[]{10,3,2,4,8,5,89,63}));
       //  Console.WriteLine(MinMax23(new int[]{10,3,2,4,8,5,89,63}));
       //  Console.WriteLine(MinMax24(new int[]{10,3,2,4,8,5,89,63}));
       //  Console.WriteLine(MinMax25(new int[]{10,3,2,4,8,5,63,89}));
       //  Console.WriteLine(MinMax26(new int[]{10,3,2,4,8,5,63,89}));
       //  Console.WriteLine(MinMax27(new int[]{0,0,1,1,1,1,0,0}));
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
        for (int i = 0; i < numbers.Length; i++)
        {
            if(numbers[i] > max )
            {
                max = numbers[i];
                firstMax = i;
            }
            else if (numbers[i] == max)
            {
                LastMax = i;
            }
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

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > B && numbers[i] < minAboveB)
            {
                minAboveB = numbers[i];
            }
        }
        return minAboveB;
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

    static int MinMax16(int[] numbers)
    {
        int min = numbers.Min();
        int count = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNumber = numbers[i];
            
            if(currentNumber != min)
            {
                count++;
            }
        }
        return count;
    }

    static int MinMax17(int[] numbers)
    {
        int max = int.MinValue;
        int lastIndex = -1;

        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            int currentNumber = numbers[i];
            
            if (currentNumber > max)
            {
                max = currentNumber;
                lastIndex = i;
            }
            if (lastIndex == -1)
            {
                return 0;
            }
        }
        return numbers.Length -1- lastIndex;
    }
    
    static int MinMax18(int[] numbers)
    {
        int max = int.MinValue;
        int firstMaxIndex = -1;
        int lastMaxIndex = -1;

        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNumber = numbers[i];
            if (currentNumber > max)
            {
                max = numbers[i];
                firstMaxIndex = i;
               
            }
            else if (currentNumber == max)
            {
                lastMaxIndex = i;
            }
        }

        if (firstMaxIndex == lastMaxIndex)
        {
            return 0;
        }
        return Math.Abs(lastMaxIndex - firstMaxIndex) - 2;
    }

    static int MinMax19(int[] numbers)
    {
        int min = numbers[0];
        int count = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
                count = 1;
            }
            else if (numbers[i] == min)
            {
                count++; 
            }
        }

        return count;
    }

    static int MinMax20(int[] numbers)
    {
        int min = numbers.Min();
        int max = numbers.Max();
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == min || numbers[i] == max)
            {
                count++; 
                Console.WriteLine(numbers[i]);
            }
        }
        return count;
    }

    static int MinMax21(int[] numbers )
    {
        int min = numbers.Min();
        int max = numbers.Max();
        int sum = 0;
        int extCount = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] != min && numbers[i] != max )
            {
                sum += numbers[i];
               Console.WriteLine(numbers[i]);
            }
            else if(numbers[i] == min || numbers[i] == max)
            {
                extCount += 1;
            }
        }
        return (sum) / (numbers.Length - extCount);
    }

    static (int firstMin , int LastMin) MinMax22(int[] numbers)
    {
        int smallest = int.MaxValue;
        int secondSmallest = int.MaxValue;

        foreach (int num in numbers)
        {
            if (num < smallest)
            {
                secondSmallest = smallest;
                smallest = num;
            }
            else if (num < secondSmallest)
            {
                secondSmallest = num;
            }
        }

        return (smallest,secondSmallest);
    }
    
    static (int firstLargest , int secondLargest , int thirdLargest) MinMax23(int[] numbers)
    {
        int firstLargest = int.MinValue;
        int secondLargest = int.MinValue;
        int thirdLargest = int.MinValue;
        foreach (var num in numbers)
        {
            if(num > firstLargest)
            {
                thirdLargest = secondLargest;
                secondLargest = firstLargest;
                firstLargest = num;
            }
            else if(num > secondLargest)
            {
                thirdLargest = secondLargest;
                secondLargest = num;
            }
            else if(num > thirdLargest)
            {
                thirdLargest = num;
            }
        }

        return (firstLargest, secondLargest, thirdLargest);
    }

    static int MinMax24(int[] numbers)
    {
        int maxSum = int.MinValue;
        for (int i = 0; i < numbers.Length-1; i++)
        {
            int currentSum = numbers[i] += numbers[i + 1];
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }
        }
        return maxSum;
    }

    static (int secondNum,int firstNum) MinMax25(int[] numbers)
    {
        int firstNum = 0;
        int secondNum = 0;
        int maxProd = int.MinValue;
        for (int i = 0; i < numbers.Length-1; i++)
        {
            int currentProd = numbers[i] * numbers[i + 1];
            if (currentProd > maxProd)
            {
                maxProd = currentProd;
                firstNum = numbers[i];
                secondNum = numbers[i + 1];
            }
        }
        
        return( firstNum > secondNum ? (secondNum,firstNum): (firstNum,secondNum));
    }

    static int MinMax26(int[] numbers)
    {
        int maxConsecutiveEvenCount = 0;
        int currentConsecutiveEvenCount = 0;

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                currentConsecutiveEvenCount++;
                if (currentConsecutiveEvenCount > maxConsecutiveEvenCount)
                {
                    maxConsecutiveEvenCount = currentConsecutiveEvenCount;
                }
            }
            else
            {
                currentConsecutiveEvenCount = 0;
            }
        }

        return maxConsecutiveEvenCount;
    }
    
    static (int countSequence,int numbersCount) MinMax27(int[] numbers)
    {
        int longestSequenceStart = 0;
        int longestSequenceLength = 0;

        int currentSequenceStart = 0;
        int currentSequenceLength = 1;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] == numbers[i - 1])
            {
                currentSequenceLength++;
            }
            else
            {
                currentSequenceStart = i;
                currentSequenceLength = 1;
            }

            if (currentSequenceLength > longestSequenceLength)
            {
                longestSequenceStart = currentSequenceStart;
                longestSequenceLength = currentSequenceLength;
            }
        }
        
        return (longestSequenceStart,longestSequenceLength);
    }
} 