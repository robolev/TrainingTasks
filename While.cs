namespace TrainingTasks;

internal class While
{
    public void Main(string[] args)
    {
      //  Console.WriteLine(While1(9,6));
      //  Console.WriteLine(While2(9,6));
      //  Console.WriteLine(While3(9,6));
      //  Console.WriteLine(While5(9));
      //  Console.WriteLine(While6(15));
      //  Console.WriteLine(While7(10));
      //  Console.WriteLine(While8(10));
      //  Console.WriteLine(While9(3));
      //  Console.WriteLine(While10(3));
      //  Console.WriteLine(While11(9));
      //  Console.WriteLine(While12(9));
      //  Console.WriteLine(While13(9));
      //  Console.WriteLine(While14(4));
      //  Console.WriteLine(While15(4));
      //  Console.WriteLine(While16(4));
      //  Console.WriteLine(While17(372));
      //  Console.WriteLine(While18(32));
      //  Console.WriteLine(While19(37));
      //  Console.WriteLine(While20(24));
      //  Console.WriteLine(While21(24));
      //  Console.WriteLine(While22(24));
      //  Console.WriteLine(While23(24,14));
      //  Console.WriteLine(While24(24));
      //  Console.WriteLine(While25(24));
      //  Console.WriteLine(While26(24));
      //  Console.WriteLine(While27(24));
      //  Console.WriteLine(While28(24));
      //  Console.WriteLine(While29(24));
      //  Console.WriteLine(While30(14,14,8));
     }


    private int While1(int a, int b)
    {
        int r = a - b;
        while (r >= b)
        {
            r -= b;
        }

        return r;
    }

    private int While2(int a, int b)
    {
        int ret = 0;
        while ((a -= b) >= 0)
        {
            ret++;
        }

        return ret;
    }

    private (int remainder,int quotient) While3(int n, int k)
    {
        int remainder = n;
        int quotient = 0;
        while (remainder >= k)
        {
            remainder -= k;
            quotient++;
        }
        
        return (quotient, remainder);
    }

    private bool While4(int n)
    {
        int temp = 1;
        while (temp < n)
        {
            temp *= 3;
        }

        return temp == n;
    }

    private int While5(int n)
    {
        int k = 0;
        while (n > 1)
        {
            n = n / 2;
            k++;
        }
        return k;
    }

    private float While6(int n)
    {
        float result = 1;
        
        while(n >= 2)
        {
            result *= n;
            n -= 2;
        }
        return result;
    }

    private int While7(int n)
    {
        int k = 1;
        while (k*k <= n)
        {
            k++;
        }
        return k;
    }

    private int While8(int n)
    {
        int k = 1;
        while (k*k <= n)
        {
            k++;
        }
        return k-1;
    }

    private int While9(int n)
    {
        int k = 1;
        int temp = 3;
        
        while (temp <= n) 
        {
            temp *= 3;
            k++;
        }
        return k;
    }

    private int While10(int n)
    {
        int k = 0;
        int temp = 3;
        
        while (temp <= n) 
        {
            temp *= 3;
            k++;
        }
        
        return k;
    }

    private (int k,int sum) While11(int n)
    {
        int k = 0;
        int sum = 0;
        while (sum < n)
        {
            k++;
            sum += k;   
        }
        return (k, sum);
    }

    private (int k,int sum) While12(int n)
    {
        int k = 1;
        int sum = 0;
        while (sum <= n)
        {
            k++;
            sum += k;   
        }
        return (k,sum);
    }
    
    private (double k,double sum) While13(int a)
    {
        double k = 1;
        double sum = 0;
        
        while (sum < a)
        {
            sum += 1.0 / k;
            k++;
        }

        return (k, sum);
    }


    private (double k,double sum) While14(int a)
    {
        double k = 0;
        double sum = 0;
        
        while (sum < a)
        {
            k++;
            sum += 1.0 / k;
        }
        return (k, sum);
    }

    private (int month,double count) While15(double p)
    {
        double count = 1000;
        int month = 0;
        while(count < 1100)
        {
            count += count * (p / 100);
            month++;
        }

        return (month,count);
    }

    private (int k,double coveredDistance) While16(double p)
    {
        double coveredDistance = 10;
        int target_distance = 200;
        int k = 0;
        while(coveredDistance < target_distance)
        {
            coveredDistance +=coveredDistance * (p / 100);
            
            k++;
        }

        return (k, coveredDistance);
    }
    
    private int While17(int n)
    {
        int reversed = 0;
        while (n > 0)
        {
            reversed = reversed * 10 + n % 10;
            n /= 10;
        }
        return reversed;
    }

    private (int sum,int count) While18(int n)
    {
        int sum = 0;
        int count = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
            count++;
        }

        return (sum, count);
    }

    private int While19(int n)
    {
        int reversed = 0;
        while (n > 0)
        {
            int digit = n % 10; 
            reversed = reversed * 10 + digit;
            n /= 10; 
        }
        return reversed;
    }

    private bool While20(int n )
    {
        int result = 0;
        while (n > 0)
        {
            result = n % 10;
           
            if (result == 2)
            {
                return true;
                break;
            }
            n /= 10;
        }
        return false;
    }

    private bool While21(int n)
    {
        int result = 0;
        while (n > 0)
        {
            result = n % 10;
           
            if (result %2 !=0)
            {
                return true;
                break;
            }
            n /= 10;
        }
        return false;
    }

    private bool While22(int n)
    {
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                return false;
                break;
            }
        }
        return true;
    }

    private int While23(int a ,int b)
    {  
        while (b != 0)
        {
            int temp = a % b;
            a = b;
            b = temp;
        } 
        return a;
    }

    private bool While24(int n)
    {
        int f1 = 1;
        int f2 = 1;
        int f3 = 0;
        while (f3 <= n)
        {
            f3 = f1 + f2;
            f1 = f2;
            f2 = f3;
            if (f3 == n)
            {
                return true;
                break;
            }
        }
        return false;
    }

    private int While25(int n)
    {
        int f1 = 1;
        int f2 = 1;
        int f3 = 0;
        while (f3 < n)
        {
            f3 = f1 + f2;
            f1 = f2;
            f2 = f3;
        }
        return f3;
    }

    private (int f1,int f3) While26(int n)
    {
        int f1 = 1;
        int f2 = 1;
        int f3 = 0;
        while (f3 < n)
        {
            f3 = f1 + f2;
            f1 = f2;
            f2 = f3;
        }
        return (f1,f3);
    }

    private int While27(int n)
    {
        int f1 = 1;
        int f2 = 1;
        int f3 = 0;
        int k = 0;
        while (f3 < n)
        {
            f3 = f1 + f2;
            f1 = f2;
            f2 = f3;
            k++;
        }
        return k;
    }

    private (int k,double a1,double a2) While28(int e)
    {
        double a1 = 2;
        double a2 = 2 + 1 / a1;
        int k = 2;
        
        while (Math.Abs(a2 - a1) >= e)
        {
            a1 = a2;
            a2 = 2 + 1 / a1;
            k++;
        }

        return (k, a1, a2);
    }

    public (int k,double a1,double a2,double a3) While29(int e)
    {
        double a1 = 1;
        double a2 = 2;
        double a3 = (a2 + 2*a1)/3;
        int k = 2;
        
        while (Math.Abs(a3 - a2) >= e)
        {
            a1 = a2;
            a2 = a3;
            a2 = (a1 + 2 * a2) / 3;
            k++;
        }
        return (k,a1,a2,a3);
    }
    
    public int While30(int a,int b,int c)
    {
        int horizontalSquares = a / c; 
        int verticalSquares = b / c;   

        int totalSquares = horizontalSquares * verticalSquares; 
        return totalSquares;
    }
}