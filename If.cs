namespace TrainingTasks;

public class If
{
    public void Main(string[] args)
    {
      //  Console.WriteLine(If1(-3));
      //  Console.WriteLine(If2(-3));
      //  Console.WriteLine(If3(0));
      //  Console.WriteLine(If6(5,4));
      //  Console.WriteLine(If7(3,4));
      //  Console.WriteLine(If8(3,4));
      //  Console.WriteLine(If9(3,4));
      //  Console.WriteLine(If10(4,4));
      //  Console.WriteLine(If11(4,4));
      //  Console.WriteLine(If12(new int[]{10,12,3}));
      //  Console.WriteLine(If13(10,12,3));
      //  Console.WriteLine(If14(10,12,3));
      //  Console.WriteLine(If15(10,12,3));
      //  Console.WriteLine(If16(10,12,3));
      //  Console.WriteLine(If17(10,12,3));
      //  Console.WriteLine(If18(10,12,3));
      //  Console.WriteLine(If19(10,10,10,4));
      //  Console.WriteLine(If20(13,10,1));
      
    }

    static int If1(int num)
    {
        if (num > 0)
        {
            num ++;
        }
        return num;
    }

    static int If2(int num)
    {
        if (num > 0)
        {
            num ++;
        }
        else
        {
            num -= 2;
        }
        return num;
    }
    
    static int If3(int num)
    {
        if (num > 0)
        {
            num ++;
        }
        else if(num < 0)
        {
            num -= 2;
        }
        else
        {
            num = 10;
        }
        return num;
    }
    
    static int If4(int a, int b, int c)
    {
        int positive = 0;

        if (a > 0)
        {
            positive += 1;
        }

        if (b > 0)
        {
            positive += 1;
        }

        if (c > 0)
        {
            positive += 1;
        }

        return positive;
    }
    
    static (int positive,int negative) If5(int a, int b, int c)
    {
        int positiveCount = 0;
        int negativeCount = 0;

        if (a > 0)
        {
            positiveCount++;
        }
        else if (a < 0)
        {
            negativeCount++;
        }

        if (b > 0)
        {
            positiveCount++;
        }
        else if (b < 0)
        {
            negativeCount++;
        }

        if (c > 0)
        {
            positiveCount++;
        }
        else if (c < 0)
        {
            negativeCount++;
        }
        return(positiveCount,negativeCount);
    }
    
    static int If6(int a, int b)
    {
        return a > b ? a : b;
    }

    static int If7(int a, int b)
    {
        return a > b ? 1 : 2;
    }
    
    static (int bigger,int smaller) If8(int a, int b)
    {
        return a > b ? (a,b) : (b,a);
    }
    
    static (double smaller,double bigger) If9(double a,double b)
    {
        return a < b ? (a, b) = (b, a):(a,b);
    }
    
    static (int a,int b) If10(int a,int b)
    {
        return a != b ? (a + b,a + b):(a = 0,b = 0);
    }
    
    static (int a,int b) If11(int a,int b)
    {
        int max = Math.Max(a, b);
        return a != b ? (a = max, b = max) : (a = 0, b = 0);
    }
    
    static int If12( int[] numbers)
    {
        int min = numbers.Min();
        return min;
    }
    
    static int If13( int a,int b,int c)
    {
        int middle = a + b + c - Math.Min(Math.Min(a, b), c) - Math.Max(Math.Max(a, b), c);
        return middle;
    }
    
    static (int smaller,int bigger) If14( int a,int b,int c)
    {
        return (Math.Min(Math.Min(a, b), c),Math.Max(Math.Max(a, b), c));
    }

    static int If15(int a,int b,int c)
    {
        return  a + b + c - Math.Min(Math.Min(a, b), c);
    }
    
    static (float a,float b,float c) If16(float a,float b,float c)
    {
        return a < b && b < c ? (a*2,b*2,c*2) : (a*-1,b*-1,c*-1);
    }
    
    static (float a,float b,float c) If17(float a,float b,float c)
    {
        return a < b && b < c || a > b && b > c ? (a*2,b*2,c*2) : (a*-1,b*-1,c*-1);
    }
    
    static int If18(float a,float b,float c)
    {
        if (a == b)
        {
            return 3;
        }
        else if (a == c)
        {
            return 2;
        }
        else
        {
            return 1;
        }
    }

    static int If19(float a, float b, float c,float d)
    {
        if (a == b && b == c)
        {
            return 4;
        }
        else if (a == b && b == d)
        {
            return 3;
        }
        else if (a == c && c == d)
        {
            return 2;
        }
        else
        {
            return 1;
        }
    }
    
    static double If20(float a,float b,float c)
    {
        double distanceB = Math.Abs(b - a); 
        double distanceC = Math.Abs(c - a);
        return  (distanceB < distanceC) ? distanceB : (distanceC < distanceB) ? distanceC : distanceB;
    }
}