namespace TrainingTasks;

public class Integer
{
    public void Main(string[] args)
    {
      // Console.WriteLine(Integer1(200));
      // Console.WriteLine(Integer2(2000));
      // Console.WriteLine(Integer3(2000));
      // Console.WriteLine(Integer4(100,10));
      // Console.WriteLine(Integer5(155,10));
      // Console.WriteLine(Integer6(34));
      // Console.WriteLine(Integer7(34));
      // Console.WriteLine(Integer8(34));
      // Console.WriteLine(Integer9(342));
      // Console.WriteLine(Integer10(342));
      // Console.WriteLine(Integer11(342));
      // Console.WriteLine(Integer12(342));
      // Console.WriteLine(Integer13(342));
      // Console.WriteLine(Integer14(342));
      // Console.WriteLine(Integer15(123));
      // Console.WriteLine(Integer16(123));
      // Console.WriteLine(Integer17(2123));
      // Console.WriteLine(Integer18(2123));
      // Console.WriteLine(Integer19(1200));
      // Console.WriteLine(Integer20(1600));
      // Console.WriteLine(Integer21(1600));
      // Console.WriteLine(Integer22(22600));
      // Console.WriteLine(Integer23(22600));
      // Console.WriteLine(Integer24(25));
      // Console.WriteLine(Integer25(27));
      // Console.WriteLine(Integer26(27));
      // Console.WriteLine(Integer27(5));
      // Console.WriteLine(Integer28(5,2));
      // Console.WriteLine(Integer29(5,2,4));
      // Console.WriteLine(Integer30(2023));
    }

    static int Integer1(int l)
    {
        return l / 100;
    }
    
    static int Integer2(int m)
    {
        return  m / 1000;
    }

    static int Integer3(int m)
    {
        return m / 1000;
    }
    
    static int Integer4(int a ,int b)
    {
        int quotient = a / b;
        return quotient;
    }
    
    static int Integer5(int a ,int b)
    {
        int remainder = a % b;
        return remainder;
    }
    
    static int Integer6(int ab)
    {
        int a = ab /10;
        int b = ab % 10;
        int result = b * 10 +a;
        return result;
    }
    
    static (int sum,int prod) Integer7(int ab)
    {
        int a = ab /10;
        int b = ab % 10;
        int sum = b + a;
        int prod = b * a;
        return (sum,prod);
    }
    
    static int Integer8(int ab)
    {
        int a = ab /10;
        int b = ab % 10;
        int result = b * 10 +a;
        return result;
    }
    
    static int Integer9(int abc)
    {
        int a = abc /100;
        return a;
    }
    
    static (int c ,int b) Integer10(int abc)
    {
        int c = abc % 10;
        int b = abc / 10 % 10;
        return ( c,b);
    }
    
    static (int sum,int prod) Integer11(int abc)
    {
        int a = abc /100;
        int b = abc / 10 % 10;
        int c = abc % 10;
        int sum = b + a + c;
        int prod = b * a * c;
        return (sum,prod);
    }
    
    static int Integer12(int abc)
    {
        int a = abc /100;
        int b = abc / 10 % 10;
        int c = abc % 10;
        int result = c * 100 + b * 10 + a;
        return result;
    }
    
    static int Integer13(int abc)
    {
        int a = abc /100;
        int b = abc / 10 % 10;
        int c = abc % 10;
        int result = b * 100 + c * 10 + a;
        return result;
    }
    
    static int Integer14(int abc)
    {
        int a = abc /100;
        int b = abc / 10 % 10;
        int c = abc % 10;
        int result =  c * 100 + a * 10 + b;
        return result;
    }
    
    static int Integer15(int abc)
    {
        int a = abc /100;
        int b = abc / 10 % 10;
        int c = abc % 10;
        int result =  b * 100 + a * 10 + c;
        return result;
    }
    
    static int Integer16(int abc)
    {
        int a = abc /100;
        int b = abc / 10 % 10;
        int c = abc % 10;
        int result =  a * 100 + c * 10 + b;
        return result;
    }
    
    static int Integer17(int abcd)
    {
        return abcd /100 % 10;
    }
    
    static int Integer18(int abcd)
    {
        return abcd /1000;
    }
    
    static int Integer19(int n)
    {
        return n /60;
    }
    
    static int Integer20(int n)
    {
        return n / 3600;
    }
    
    static int Integer21(int n)
    {
        return n % 60;
    }
    
    static int Integer22(int n)
    {
        return n % 3600;
    }
    
    static int Integer23(int n)
    {
        return n % 3600 / 60;
    }
    
    static int Integer24(int k)
    {
        int d = k % 7;
        return d;
    }

    static int Integer25(int k)
    {
        int d = (k + 3) % 7;
        return d;
    }
    
    static int Integer26(int k)
    {
        int d = (k % 7) +1;
        return d;
    }

    static int Integer27(int k)
    {
        int dayOfWeek = (k + 5 -1) % 7 + 1;
        return dayOfWeek;
    }

    static int Integer28(int k,int n)
    {
        return (n + (k - 1)) % 7;
    }

    static (int count,int area) Integer29(int a, int b, int c)
    {
        int count = (a / c) * (b / c);
        int area = a * b - count * c * c;
        return  (count, area);
    }
    
    static int Integer30(int y)
    {
        int century = (y - 1) / 100 + 1;
        return  (century);
    }
}