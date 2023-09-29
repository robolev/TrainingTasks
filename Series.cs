namespace TrainingTasks;

public class Series
{
    public void Main(string[] args)
    {
      //  Console.WriteLine(Series1(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));  
      //  Console.WriteLine(Series2(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
      //  Console.WriteLine(Series3(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
      //  Console.WriteLine(Series4(4,new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
      //  Console.WriteLine(Series5(7,new float[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
      //  Console.WriteLine(Series6(10,new float[] { 1, 2, 3, 4, 5, 6, (float)7.05, 8, 9, 10 }));
      //  Console.WriteLine(Series7(10,new float[] { 1, 2, 3, 4, 5, 6, (float)7.05, 8, 9, 10 }));
      //  Console.WriteLine(Series8(10,new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
      //  Console.WriteLine(Series9(10,new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
      //  Console.WriteLine(Series10(10,new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
      //  Console.WriteLine(Series11(10,5,new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
      //  Series12(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
      //  Series13(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
      //  Series14(5,new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
      //  Series15(5,new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
      //  Series16(5,new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
      //  Series17(5,new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
      //  Series25(5,new int[] { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
          int[][] sets = new int[][] {
             new int[] { 1, 2, 3 },
             new int[] { 4, 5, 6 },
             new int[] { 7, 8, 9 },
             new int[] { 10, 2,11, 12, 2 },
             new int[] { 13, 14, 15 }
         };
     //  Console.WriteLine(Series31(sets));
     //  Series32(5,sets);
     //  Series33(5,sets);
    }

   

    static int Series1(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    static float Series2(int[] numbers)
    {
        float sum = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum *= numbers[i];
        }
        return sum;
    }
    
    static int Series3(int[] numbers)
    {
        int sum = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum *= numbers[i];
        }
        return sum/numbers.Length;
    }

    static (double sum,double pro) Series4(int n,int[] numbers)
    {
        double sum = 0;
        double pro = 1;
        for (int i = 0; i < n; i++)
        {
            sum += numbers[i];
            pro *= numbers[i];
        }
        return (sum,pro);
    }
    
    static double Series5(int n,float[] numbers)
    {
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = MathF.Round(numbers[i], 0);
            sum += numbers[i];
            Console.WriteLine(numbers[i]);
        }
        return sum;
    }

    static double Series6(int n,float[] numbers)
    {
        double prod = 0;
        for (int i = 0; i < n; i++)
        {
            numbers[i] =numbers[i] - MathF.Round(numbers[i], 0);
            prod *= numbers[i];
            Console.WriteLine(numbers[i]);
        }
        return prod;
    }

    static double Series7(int n,float[] numbers)
    {
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = MathF.Round(numbers[i], 0);
            sum += int.Parse(numbers[i].ToString());
            Console.WriteLine(numbers[i]);
        }
        return sum;
    }

    static int Series8(int n , int[] numbers)
    {
        int k=0;
        for (int i = 0; i < n; i++)
        {
            if (numbers[i]%2 == 0)
            {
                Console.WriteLine(numbers[i]);
                k++;
            }
        }   
        return k;
    }

    static int Series9(int n,int[] numbers)
    {
        int k=0;
        for (int i = 0; i < n; i++)
        {
            if (numbers[i]%2 != 0)
            {
                Console.WriteLine(numbers[i]);
                k++;
            }
        }
        return k;
    }

    static bool Series10(int n,int[] numbers)
    {
        int k=0;
        for (int i = 0; i <= n; i++)
        {
            if (numbers[i] > 0)
            {
                return true;
            }
        }
        return false;
    }

    static bool Series11(int n,int k,int[] numbers)
    {
        bool status = false;
        for (int i = 0; i <= n; i++)
        {
            if (numbers[i] < k)
            {
                status = true;
                break;
            }
        }
        return status;
    }

    static void Series12(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 0)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }

    static void Series13(int[] numbers)
    {
        int sum=0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (numbers[i] %2 == 0 && numbers[i] > 0)
            {
                sum += numbers[i];
            }
        }
        Console.WriteLine(sum);
    }

    static void Series14(int k,int[] numbers)
    {
        int count = 0;
        int index = -1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 0)
            {
                index = i; 
                break;
            }
            else if (numbers[i] < k)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }

    static void Series15(int k,int[] numbers)
    {
        int num = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 0)
            {
                Console.WriteLine(i);
                break;
            }else if (numbers[i] > k)
            {
                num = i;
                break;
            }
        }
        Console.WriteLine(num);
    }

    static void Series16(int k,int[] numbers)
    {
        int num = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 0)
            {
                Console.WriteLine(i);
                break;
            }else if (numbers[i] > k)
            {
                num = i;
            }
        }
        Console.WriteLine(num);
    }

   
    static void Series17(double b,int n,int[] numbers)
    {
        int num = 0;
        for (int i = 0; i < n; i++)
        {
            if (numbers[i] > b)
            {
                Console.WriteLine(b);
                Console.WriteLine(numbers[i]);
            }
            else
            {
                Console.WriteLine(numbers[i]);
            }
        }
        Console.WriteLine(num);
    }

    static void Series18(int n,int[] numbers)
    {
        int num = 0; 
        for (int i = 0; i < n; i++)
        {
            if (numbers[i] > num)
            {
                Console.WriteLine(numbers[i]);
                num = numbers[i];
            }
        }
    }

    static void Series19(int n,int[] numbers)
    {
        int count = 0; 
        for (int i = 0; i < n; i++)
        {
            if (numbers[i] < numbers[i - 1])
            {
                Console.WriteLine(numbers[i]);
                count++;
            }
        }
    }

    static void Series20(int n,int[] numbers)
    {
        int count = 0; 
        for (int i = 0; i < n; i++)
        {
            if (numbers[i] < numbers[i + 1])
            {
                Console.WriteLine(numbers[i]);
                count++;
            }
        }
    }
    
    static bool Series21(int n,int[] numbers)
    {
        bool status = false;
        for (int i = 0; i < n; i++)
        {
            if (numbers[i] < numbers[i + 1])
            {
                status = true;
            }
            else
            {
                status = false;
            }
        }
        return status;
    }

    static int Series22(int n,int[] numbers)
    {
        for (int i = 0; i < n - 1; i++)
        {
            if (numbers[i] > numbers[i + 1])
            {
                return i + 1;
            }
        }
        return 0;
    }

    static int Series23(int n,int[] numbers)
    {
        for (int i = 1; i < n - 1; i++)
        {
            if (!((numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1]) ||
                  (numbers[i] < numbers[i - 1] && numbers[i] < numbers[i + 1])))
            {
                return i;
            }
        }
        return 0;
    }

    static int Series24(int n,int[] numbers)
    {
        int sum = 0;
        bool foundFirstZero = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 0)
            {
                if (foundFirstZero)
                {
                    return sum;
                }
                foundFirstZero = true;
                sum = 0;
            }
            else if (foundFirstZero)
            {
                sum += numbers[i];
            }
        }

        return 0;
    }
    
    static int Series25(int n, int[] numbers)
    {
        int sum = 0;
        bool foundFirstZero = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 0)
            {
                if (foundFirstZero)
                {
                    return sum;
                }
                foundFirstZero = true;
            }
            else if (foundFirstZero)
            {
                sum += numbers[i];
            }
        }

        return 0;
    }
    
    static float Series26(int k ,int n, int[] numbers)
    {
        for (int i = 0; i < n; i++)
        {
            float result = 1;
            for (int j = 0; j < k; j++)
            {
                result *= numbers[i];
            }

            return result;
        }
        return 0;
    }

    static float Series27(int n, int[] numbers)
    {
        for (int i = 0; i < n; i++)
        {
            float result = 1;
            for (int j = 0; j <  i + 1; j++)
            {
                result *= numbers[i];
            }

            return result;
        }
        return 0;
    }
    
    static float Series28(int n, int[] numbers)
    {
        for (int i = 0; i < n; i++)
        {
            float result = 1;
            for (int j = 0; j <  n - i; j++)
            {
                result *= numbers[i];
            }

            return result;
        }
        return 0;
    }

    static float Series29(int n, int k, int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < n * k; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }

    static float Series30(int n, int k, int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i <  n * k; i++)
        {
            for (int j = 0; j < n; j++)
            {
                sum += numbers[i];
            }
        }

        return sum;
    }
    
    static int Series31(int[][] sets)
    {
        int count = 0;

        foreach (var set in sets)
        {
            foreach (var num in set)
            {
                if (num == 2)
                {
                    count++;
                    break; 
                }
            }
        }
        return count;
    }
    
    static void Series32(int k, int[][] sets)
    {
        for (int i = 0; i < k; i++)
        {
            int index = FindIndexOfTwo(sets[i]);
            Console.WriteLine(index);
        }
    }
    
    static int FindIndexOfTwo(int[] set)
    {
        for (int i = 0; i < set.Length; i++)
        {
            if (set[i] == 2)
            {
                return i + 1; 
            }
        }
        return 0; 
    }

    static void Series33(int k,int[][] sets)
    {
        for (int i = 0; i < k; i++)
        {
            int index = FindLastIndexOfTwo(sets[i]);
            Console.WriteLine(index);
        }
    }
    
    static int FindLastIndexOfTwo(int[] set)
    {
        int result = 0;
        for (int i = 0; i < set.Length; i++)
        {
            if (set[i] == 2)
            {
                result = i + 1; 
            }
        }
        return result; 
    }

}