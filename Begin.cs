namespace TrainingTasks;

public class Begin
{
    public void Main(string[] args)
    {
       // Console.WriteLine(Begin1(2));
       // Console.WriteLine(Begin2(4));
       // Console.WriteLine(Begin3(5, 4));
       // Console.WriteLine(Begin4(4));
       // Console.WriteLine(Begin5(3));
       // Console.WriteLine(Begin6(4,5,6));
       // Console.WriteLine(Begin7(6));
       // Console.WriteLine(Begin8(2,3));
       // Console.WriteLine(Begin9(2,3));
       // Console.WriteLine(Begin10(4,5));
       // Console.WriteLine(Begin11(4,5));
       // Console.WriteLine(Begin12(3,6));
       // Console.WriteLine(Begin13(5,4));
       // Console.WriteLine(Begin14(10));
       // Console.WriteLine(Begin15(10));
       // Console.WriteLine(Begin16(5,3));
       // Console.WriteLine(Begin17(5,3,6));
       // Console.WriteLine(Begin18(5,3,6));
       // Console.WriteLine(Begin19(5,3,6,8));
       // Console.WriteLine(Begin19(5,3,6,8));
       // Console.WriteLine(Begin20(5,3,6,8));
       // Console.WriteLine(Begin21(5,3,6,8,3,7));
       // Console.WriteLine(Begin22(24));
       // Console.WriteLine(Begin23(245));
       // Console.WriteLine(Begin24(245));
       // Console.WriteLine(Begin25(2));
       // Console.WriteLine(Begin26(2));
       // Console.WriteLine(Begin27(2));
       // Console.WriteLine(Begin28(2));
       // Console.WriteLine(Begin29(180));
       // Console.WriteLine(Begin30(4));
       // Console.WriteLine(Begin31(39));
       // Console.WriteLine(Begin32(14));
       // Console.WriteLine(Begin33(1,8,5));
       // Console.WriteLine(Begin34(1,8,5,6));
       // Console.WriteLine(Begin35(1,8,5,7));
       // Console.WriteLine(Begin36(1,8,5,7));
       // Console.WriteLine(Begin37(1,8,5,7));
       // Console.WriteLine(Begin38(1,8));
       // Console.WriteLine(Begin39(1,8,3));
       // Console.WriteLine(Begin40(10, 82, 3, 42, 33, 42));

    }

    static int Begin1(int a)
    {
        int p = a * 4;
        return p;
    }

    static int Begin2(int a)
    {
        int s = a * a;
        return s;
    }

    static (int s, int p) Begin3(int a, int b)
    {
        int s = a * b;
        int p = 2 * (a + b);
        return (s, p);
    }

    static double Begin4(double d)
    {
        double l = Math.PI * d;
        return l;
    }
    
    static (int v, int s) Begin5(int a)
    {
        int v = a * a * a;
        int s = 6 * (a * a);
        return (v, s);
    }
    
    static (int v, int s) Begin6(int a,int b,int c)
    {
        int v = a * b * c;
        int s = 2 * (a * b + b * c + a * c);
        return (v, s);
    }

    static (double l, double s) Begin7(int r)
    {
        double l = 2 * Math.PI * r;
        double s = Math.PI * (r * r);
        return (l, s);
    }
    
    static double Begin8(int a,int b)
    {
        double result = a + b / 2; 
        return result;
    }
    
    static double Begin9(int a,int b)
    {
        double result = Math.Sqrt(a*b); 
        return result;
    }
    
    static (double sum, double dif,double prod,double quotient) Begin10(int a,int b)
    {
        double sum = (a * a) + (b * b);
        double dif = (a * a) - (b * b);
        double prod = (a * a) * (b * b);
        double quotient = (a * a) /(b * b);
        return (sum, dif, prod, quotient);
    }
    
    static (double sum, double dif,double prod,double quotient) Begin11(int a,int b)
    {
        double sum = Math.Abs(a) + Math.Abs(b);
        double dif = Math.Abs(a) - Math.Abs(b);
        double prod = Math.Abs(a) * Math.Abs(b);
        double quotient = Math.Abs(a) / Math.Abs(b);
        return (sum, dif, prod, quotient);
    }

    static (double c, double p) Begin12(int a, int b)
    {
        double c = Math.Sqrt((a*a) + (b*b));
        double p = a + b + c;
        return (c, p);
    }
    
    static (double s1, double s2,double s3) Begin13(int r1, int r2)
    {
        double s1 = Math.PI * (r1 * r1);
        double s2 = Math.PI * (r2 * r2);
        double s3 = s1 - s2;
        return (s1, s2,s3);
    }
    
    static (double r, double s) Begin14(int l)
    {
        double r = l / 2 * Math.PI; 
        double s = Math.PI * (r * r);
        return(r,s);
    }
    
    static (double d, double l) Begin15(int s)
    {
        double r = Math.Sqrt(s / Math.PI);
        double l = 2 * Math.PI * r;
        return(r,l);
    }

    static double Begin16(int x1,int x2)
    {
        double distance = Math.Abs(x2 - x1);
        return distance;
    }

    static double Begin17(int a,int b , int c)
    {
        double ac = Math.Abs(c-a);
        double bc = Math.Abs(c-b);
        double sum = ac + bc;
        return sum;
    }

    static double Begin18(int a,int b , int c)
    {
        double ac = Math.Abs(c-a);
        double bc = Math.Abs(b-c);
        double quotient = ac * bc;
        return quotient;
    }
    
    static (double p, double s) Begin19(int x1,int x2,int y1,int y2)
    {
        double x = Math.Abs(x2 - x1);
        double y = Math.Abs(y2 - y1);
        double p =  2 * (x + y);
        double s = x * y;
        return (p, s);
    }
    
    static double Begin20(int x1,int x2,int y1,int y2)
    {
        double distance = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));
        return distance;
    }

    static (double p,double s) Begin21(int x1,int x2,int y1,int y2,int x3,int y3)
    {
        double a = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        double b = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
        double c = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));
        double p = (a + b + c) / 2;
        double P = (a + b + c);
        double s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        return (P,s);
    }

    static int Begin22(int num)
    {
        int b = num / 10 % 10;
        int c = num % 10;
        int result = c * 10 + b;
        return result;
    }

    static int Begin23(int num)
    {
        int a = num / 100 *10;
        int b = num / 10 % 10;
        int c = num % 10 * 100;
        int result = c+a+b;
        return result;
    }

    static int Begin24(int num)
    {
        int a = num / 100;
        int b = num / 10 % 10 * 100;
        int c = num % 10 * 10;
        int result = b + c + a;
        return result;
    }

    static int Begin25(int x)
    {
        int xSquared = x * x; 
        int xToTheSixth = xSquared * xSquared * xSquared ;
        int y = 3 * xToTheSixth - 6 * xSquared - 7; 
        return y;
    }

    static int Begin26(int x)
    {
        int xToTheThird = (x-3)*(x-3)*(x-3);
        int y = 4*(xToTheThird * xToTheThird) - 7 * xToTheThird;
        return y;
    }

    static (int a2,int a4,int a8) Begin27(int a)
    {
        int a2 = a * a; 
        int a4 = a2 * a2; 
        int a8 = a4 * a4; 
        return (a2,a4,a8);
    }
    
    static (int a2,int a3,int a5,int a10,int a15) Begin28(int a)
    {
        int a2 = a * a; 
        int a3 = a2 * a; 
        int a5 = a2 * a3; 
        int a10 = a5 * a5; 
        int a15 = a10 * a5; 
        return (a2,a3,a5,a10,a15);
    }

    static double Begin29(int a)
    {
        double rad = a * Math.PI / 180;
        return rad;
    }
    
    static double Begin30(int a)
    {
        double degress = a * 180 / Math.PI;
        return degress;
    }
    
    static double Begin31(int t)
    {
        double tc = (t-32) * 5 /9;
        return tc;
    }
    
    static double Begin32(int t)
    {
        double tf = (t-5 /9) * 39;
        return tf;
    }

    static (double y,double pricePer1Kg) Begin33(int x,int a,int y)
    {
        double pricePer1Kg = a / x;
        double pricePerYKg = a*y;
        return (pricePer1Kg, pricePerYKg);
    }
    
    static (double pricePer1KgX,double pricePer1KgY,double dif) Begin34(int x,int a,int y,int b)
    {
        double pricePer1KgX = a / x;
        double pricePer1KgY = b / y;
        double dif = pricePer1KgY - pricePer1KgX;
        return (pricePer1KgX, pricePer1KgY,dif);
    }
    
    
    static double  Begin35(double V,double U,double T1,double T2)
    {
        double LakeDistance  = T1 * V;
        double RiverDistanceAgainstCurrent = T2 * (V - U);
        double TotalDistance = LakeDistance + RiverDistanceAgainstCurrent;
        return (TotalDistance);
    }

    static double Begin36(double V1, double V2, double S, double T)
    {
        double TotalSpeed = V1 + V2;
        double Distance = S + (T * TotalSpeed);
        return Distance;
    }

    static double Begin37(double V1, double V2, double S, double T)
    {
        double TotalSpeed = V1 + V2;
        double Distance =  Math.Abs(S - (T * TotalSpeed));
        return Distance;
    }

    static float Begin38(int a,int b)
    {
        int x = -b / a;
        return x;
    }

    static (double x2,double x1) Begin39(int a, int b,int c)
    {
        int d = (b * b) - 4 * a * c;
        double x1 = -b + Math.Sqrt(d) / 2 * a;
        double x2 = -b - Math.Sqrt(d) / 2 * a;
        return (x2, x1);
    }
    
    
    static (double x,double y) Begin40(int a1, int b1,int c1,int a2,int b2,int c2)
    {
        int d = a1*b2 - a2*b1;
        double x = (c1 * b2 - c2 * b1)/d;
        double y = (a1 * c1 - a2 * c2)/d;
        return (x, y);
    }
}