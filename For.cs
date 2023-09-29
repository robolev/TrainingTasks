namespace TrainingTasks
{
    internal class For
    {
        public  void Main(string[] args)
        {
            // Console.WriteLine(For1()); 
            // Console.WriteLine(For2()); 
            // For3();
            // For4();
            // For5();
            // For6();
            // Console.WriteLine(For7()); 
            // For8();
            // For9();
            // For10();
            // For11();
            // For12();  
            // For13();
            // For14();
            // For15();
            // For16();
            // For17();
            // For18();
            // For19();
            // For20();
            // For21();
            // For22();
            // For23();
            // For24();
            // Console.WriteLine(For25(4,5));
            // Console.WriteLine(For26(4,5));
            // Console.WriteLine(For27(4,5));
            // For30();
            // For31();
            // For32();
            // For33();
            // For33();
            // For34();
            // For35();
            // For36();
            // For37();
            // For38();
            // For39();
            // For40();
        }

        static int For1()
        {
            int n = 10;
            int k = 0;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(k);
            }
            return k;
        }

        static int For2()
        {
            int a = 1;
            int b = 10;
            int count = 0;
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
                count++;
            }

            return count;
        }

        static int For3()
        {
            int a = 1;
            int b = 10;
            int count = 0;
            for (int i = b - 1; i > a; i--)
            {
                Console.WriteLine(i);
                count++;
            }
            
            return count;
        }

        static void For4()
        {
            double pricePerKg = 2;
            for (int kg = 1; kg <= 10; kg++)
            {
                double totalCost = kg * pricePerKg;
                Console.WriteLine(totalCost);
            }

        }

        static void For5()
        {
            double pricePerKg = 2;
            for (double kg = 1.2; kg <= 2; kg += 0.1)
            {
                double totalCost = kg * pricePerKg;
                Console.WriteLine(totalCost);
            }

        }

        static void For6()
        {
            double pricePerKg = 2;
            for (double kg = 1.2; kg <= 2; kg += 0.2)
            {
                double totalCost = kg * pricePerKg;
                Console.WriteLine(totalCost);
            }
        }

        static int For7()
        {
            int a = 1;
            int b = 10;
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }

            return sum;
        }

        static void For8()
        {
            int a = 1;
            int b = 10;
            int sum = 1;
            for (int i = a; i <= b; i++)
            {
                sum *= i;
            }

            Console.WriteLine(sum);
        }

        static void For9()
        {
            int a = 1;
            int b = 10;
            int sum = 1;
            for (int i = a; i <= b; i++)
            {
                sum += i * i;

            }
            Console.WriteLine(sum);
        }

        static void For10()
        {
            double n = 4;
            double result = 0.0;
            for (int i = 0; i <= n; i++)
            {
                result += 1.0 / n;
            }

            Console.WriteLine(result);
        }

        static void For11()
        {
            double n = 4;
            double result = 0.0;
            for (int i = 0; i <= n; i++)
            {
                result += (n + i) * (n + i);
            }

            Console.WriteLine(result);
        }

        static void For12()
        {
            double n = 4;
            double result = 1.0;
            for (double i = 0; i <= n; i++)
            {
                result *= 1.0 + (i * 0.1);
            }

            Console.WriteLine(result);
        }

        static void For13()
        {
            double n = 4;
            double result = 1.0;
            double sign = 1.0;
            for (double i = 0; i <= n; i++)
            {
                result += sign * 1.0 + (i * 0.1);
                sign *= -1;
            }

            Console.WriteLine(result);
        }

        static void For14()
        {
            int n = 4;
            int result = 0;
            for (int i = 1; i <= 2 * n - 1; i += 2)
            {
                result += 2 * n - 1;
                Console.WriteLine(result);
            }
        }

        static void For15()
        {
            int a = 4;
            int n = 10;
            int result = 1;
            for (int i = 0; i <= n; i++)
            {
                result *= a;
            }

            Console.WriteLine(result);
        }

        static void For16()
        {
            double a = 2.25;
            int n = 10;
            int result = 1;
            for (int i = 0; i <= n; i++)
            {
                result *= Convert.ToInt32(a);
            }

            Console.WriteLine(result);
        }

        static void For17()
        {
            double a = 2.25;
            int n = 10;
            double result = 1;
            for (int i = 0; i <= n; i++)
            {
                result += Math.Pow(a, i);
            }

            Console.WriteLine(result);
        }

        static void For18()
        {
            double n = 4;
            double a = 2.25;
            double result = 1.0;
            double sign = 1.0;
            for (double i = 0; i <= n; i++)
            {
                result += sign * Math.Pow(a, i);
                sign *= -1;
            }

            Console.WriteLine(result);
        }

        static void For19()
        {
            int n = 10;
            int result = 1; 
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }

        static void For20()
        {
            double n = 4;
            double sum = 0; 
            double factorial = 1; 
            for (int i = 1; i <= n; i++)
            {
                factorial *= i; 

                sum += factorial; 
            }

            Console.WriteLine(sum);
        }

        static void For21()
        {
            double n = 4;
            double sum = 0; 
            double factorial = 1; 
            for (int i = 1; i <= n; i++)
            {
                factorial *= i; 

                sum += 1/factorial; 
            }

            Console.WriteLine(sum);
        }

        static void For22()
        {
            int n = 4;
            int x = 2;
            double sum = 0; 
            double factorial = 1; 
            for (int i = 1; i <= n; i++)
            {
                factorial *= i; 

                sum +=  Math.Pow(x,i)/factorial; 
            }

            Console.WriteLine(sum);
        }

        static void For23()
        {
            int n = 4;
            int x = 2;
            double sum = 0; 
            double factorial = 1; 
            for (int i = 1; i <= n; i++)
            {
                factorial *= -1*(2*i + 1); 

                sum +=  Math.Pow(x,2*i+1)/factorial; 
            }

            Console.WriteLine(sum);
        }
        
        static void For24()
        {
            int n = 4;
            int x = 2;
            double sum = 0; 
            double factorial = 1; 
            for (int i = 1; i <= n; i++)
            {
                factorial *= -1*(2*i); 

                sum +=  Math.Pow(x,2*i)/factorial; 
            }

            Console.WriteLine(sum);
        }

        static double For25(int x,int n)
        {
            double power = x;
            double sum = 0;
            int sign = 1;
            for(int i = 1;i <= n;i++)
            {
                sum += sign * power/i;
                power *= x;
                sign = -sign;
            }
            return sum;
        }
        
        static double For26(int x,int n)
        {
            double result = 0;
            double sign = 1;
            double power = x;

            for (int i = 1; i <= n; i++)
            {
                result += sign * (power / (2 * i - 1));
                sign = -sign;
                power *= x; 
            }
            return result;
        }

        static double For27(int x,int n)
        {
            double result = x; 
            double power = x; 

            for (int i = 1; i <= n; i++)
            {
                power *= x * x; 

                if (i % 2 == 1) 
                {
                    result += power / (2 * i + 1); 
                }
            }

            return result;
        }
        
        static void For30()
        {
            int n = 10;
            double a = 2;
            double b = 8;
            double h = (b - a)/n;
            for (int i = 0; i < n; i++)
            {
                double x = a + i * h;
                double fx = 1 - Math.Sin(x);
                Console.WriteLine($"{x},{fx}");
            }
        }

        static void For31()
        {
            int n = 10;
            double a = 4;
            for (double i = a; i <= n; i++)
            {
                a = 2 + 1 / i - 1;
                Console.WriteLine(a);
            }
        }

        static void For32()
        {
            int n = 10;
            double ak = 0;
            for (double i = ak; i <= n; i++)
            {
                Console.WriteLine( ak+1/i);
            }
        }

        static void For33()
        {
            int a = 1;
            int b = 1;
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                int c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
        }

        static void For34()
        {
            int a = 1;
            int b = 1;
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                int c = (a + 2*b)/3;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
        }

        static void For35()
        {
            int a1 = 1;
            int a2 = 1;
            int a3 = 1;
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                int a4 = a1 + a2 - 2 * a3;
                a1 = a2;
                a2 = a3;
                a3 = a4;
            }
        }

        static void For36()
        {
            int n = 10;
            int k = 3;
            double sum = 0;
            for (int i = 0; i < n; i++)
            { 
                sum += Math.Pow(i,k);
            }
            Console.WriteLine(sum);
        }

        static void For37()
        {
            int n = 10;
            double sum = 0;
            int p = 1;
            for (int i = 0; i < n; i++)
            { 
                p *= i; 
                sum += p;
            }
            Console.WriteLine(sum);
        }
        
        static void For38()
        {
            int n = 10;
            int p = n;
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += Math.Pow(i, p+1-i);
                p--;
            }
            Console.WriteLine(sum);
        }

        static void For39()
        {
            int a = 5;
            int b = 10;
            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < i ; j++)
                {
                    Console.WriteLine(i);
                }
            }
       }
        static void For40()
        {
            int a = 5;
            int b = 10;
            int k = 1; 
            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < k ; j++)
                {
                    Console.WriteLine(i);
                }
                k++;
            }
        }
    }
}