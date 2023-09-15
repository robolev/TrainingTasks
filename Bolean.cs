namespace TrainingTasks;

public class Bolean
{
    public void Main(string[] args)
    {
       // Console.WriteLine(Bolean1(12));
       // Console.WriteLine(Bolean2(12));
       // Console.WriteLine(Bolean3(12));
       // Console.WriteLine(Bolean4(0,0));
       // Console.WriteLine(Bolean5(0,0));
       // Console.WriteLine(Bolean6(0,8,4));
       // Console.WriteLine(Bolean7(0,8,4));
       // Console.WriteLine(Bolean8(0,8));
       // Console.WriteLine(Bolean9(0,8));
       // Console.WriteLine(Bolean10(3,8));
       // Console.WriteLine(Bolean11(4,8));
       // Console.WriteLine(Bolean12(4,8,3));
       // Console.WriteLine(Bolean13(4,0,0));
       // Console.WriteLine(Bolean13(4,0,8));
       // Console.WriteLine(Bolean14(4,0,8));
       // Console.WriteLine(Bolean15(1,4,0));
       // Console.WriteLine(Bolean16(10));
       // Console.WriteLine(Bolean17(124));
       // Console.WriteLine(Bolean18(5,3,5));
       // Console.WriteLine(Bolean19(-5,3,5));
       // Console.WriteLine(Bolean20(123));
       // Console.WriteLine(Bolean21(123));
       // Console.WriteLine(Bolean22(123));
       // Console.WriteLine(Bolean23(3232));
       // Console.WriteLine(Bolean24(3,40,3));
       // Console.WriteLine(Bolean25(3,-4));
       // Console.WriteLine(Bolean26(3,-4));
       // Console.WriteLine(Bolean27(-3,-4));
       // Console.WriteLine(Bolean28(-3,-4));
       // Console.WriteLine(Bolean29(-3,-4,8,0,9,9));
       // Console.WriteLine(Bolean30(8,8,8));
       // Console.WriteLine(Bolean31(8,8,8));
       // Console.WriteLine(Bolean32(3,4,1));
       // Console.WriteLine(Bolean33(6,3,4));
       // Console.WriteLine(Bolean34(6,3));
       // Console.WriteLine(Bolean35(6,3,4,5));
       // Console.WriteLine(Bolean36(6,3,4,5));
       // Console.WriteLine(Bolean37(6,3,4,5));
       // Console.WriteLine(Bolean38(6,3,4,5));
       
    }

    static bool Bolean1(int a)
    {
        return a > 0;
    }
    static bool Bolean2(int a)
    {
        return a % 2 != 0;
    }

    static bool Bolean3(int a)
    {
        return a % 2 == 0;
    }
    
    static bool Bolean4(int a,int b)
    {
        return a > 2 && b <= 3;
    }
    
    static bool Bolean5(int a,int b)
    {
        return a >= 0 || b < -2;
    }
    
    static bool Bolean6(int a,int b,int c)
    {
        return a < b && b < c;
    }
    
    static bool Bolean7(int a,int b,int c)
    {
        return a < b && b < c || a > b && b > c;
    }
    
    static bool Bolean8(int a,int b)
    {
        return a % 2 != 0 && b % 2 != 0;
    }
    
    static bool Bolean9(int a,int b)
    {
        return a % 2 != 0 || b % 2 != 0;
    }
    
    static bool Bolean10(int a,int b)
    {
        return a % 2 != 0 ^ b % 2 != 0;
    }
    
    static bool Bolean11(int a,int b)
    {
        return (a % 2 != 0 && b % 2 != 0) || (a % 2 == 0 && b % 2 == 0); 
    }
    
    static bool Bolean12(int a,int b,int c)
    {
        return a > 0 && b > 0 && c > 0; 
    }
    
    static bool Bolean13(int a,int b,int c)
    {
        return a > 0 || b > 0 || c > 0; 
    }

    static bool Bolean14(int a,int b,int c)
    {
        return a > 0 ^ b > 0 ^ c > 0; 
    }
    
    static bool Bolean15(int a,int b,int c)
    {
        return (a > 0 && b > 0) ^ (a > 0 && c > 0) ^ (b > 0 && c > 0);
    }

    static bool Bolean16(int n)
    {
        return n < 100 && n > 9 && n % 2 == 0;
    }

    static bool Bolean17(int n)
    {
        return n < 1000 && n > 99 && n % 2 != 0;
    }
    
    static bool Bolean18(int a,int b,int c)
    {
        return (a == b) || (a == c) || (b == c);
    }
    
    static bool Bolean19(int a,int b,int c)
    {
        return (a==(-1)*b)|(a==(-1)*c)|(b==(-1)*c);
    }
    
    static bool Bolean20(int abc)
    {
        int a = abc / 100;
        int b = abc /10 %10;
        int c = abc % 10;
        return (a != b) && (b != c) && (a != c);
    }
    
    static bool Bolean21(int abc)
    {
        int a = abc / 100;
        int b = abc /10 %10;
        int c = abc % 10;
        return a < b && b < c;
    }

    static bool Bolean22(int abc)
    {
        int a = abc / 100;
        int b = abc /10 %10;
        int c = abc % 10;
        return (a < b && b < c) || ( a > b && b > c);
    }
    
    static bool Bolean23(int abcd)
    {
        int a = abcd / 1000;
        int b = abcd / 100 % 10;
        int c = abcd / 10 % 10;
        int d = abcd % 10;
        return a == d && b == c;
    }

    static bool Bolean24(int a,int b ,int c)
    {
        int d = (b * b) - 4 * a * c;
        return d > 0;
    }
    
    static bool Bolean25(int x,int y)
    {
        return x < 0 && y > 0;
    }
    
    static bool Bolean26(int x,int y)
    {
        return x > 0 && y < 0;
    }

    static bool Bolean27(int x,int y)
    {
        return x < 0 && (y > 0 || y < 0);
    }
    
    static bool Bolean28(int x,int y)
    {
        return x > 0 && y > 0 || x < 0 && y < 0 ;
    }
    
    static bool Bolean29(int x,int y,int x1,int y1,int x2,int y2)
    {
        return x1 < x && x < x2 && y2 > y && y > y1;
    }
    
    static bool Bolean30(int a,int b,int c)
    {
        return a == b && b==c;
    }
    
    static bool Bolean31(int a,int b,int c)
    {
        return (a == b) || (b == c) || (a == c);
    }
    
    static bool Bolean32(int a,int b,int c)
    {
        return a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b;
    }
    
    static bool Bolean33(int a,int b,int c)
    {
        return (a + b) > c && (a + c) > b && (b + c) > a;
    }
    
    static bool Bolean34(int x,int y)
    {
        return (x + y) % 2 != 0;
    }

    static bool Bolean35(int x1,int y1,int x2,int y2)
    {
        return (x1 + y1) % 2 == (x2 + y2) % 2;
    }
    
    static bool Bolean36(int x1,int y1,int x2,int y2)
    {
        return (x1 == x2 && y1 != y2) || (x1 != x2 && y1 == y2);
    }
    
    static bool Bolean37(int x1,int y1,int x2,int y2)
    {
        return Math.Abs(x1 - x2) <= 1 && Math.Abs(y1 - y2) <= 1;
    }
    
    static bool Bolean38(int x1,int y1,int x2,int y2)
    {
        return Math.Abs(x1 - x2) == Math.Abs(y1 - y2) && (x1 != x2 || y1 != y2);
    }
    
    static bool Bolean39(int x1,int y1,int x2,int y2)
    {
        return (x1 == x2) || (y1 == y2) || (Math.Abs(x1 - x2) == Math.Abs(y1 - y2));
    }
    
    static bool Bolean40(int x1,int y1,int x2,int y2)
    {
        return Math.Abs(x1 - x2) == 1 && Math.Abs(y1 - y2) == 1 || Math.Abs(x1 - x2) == 2 && Math.Abs(y1 - y2) == 2;
    }
}