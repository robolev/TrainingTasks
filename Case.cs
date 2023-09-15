namespace TrainingTasks;

public class Case
{
    public void Main(string[] args)
    {
      // Console.WriteLine(Case1(5));
      // Console.WriteLine(Case7(5,2));
      // Console.WriteLine(Case8(5,2));
      // Console.WriteLine(Case9(5,2));
      // Console.WriteLine(Case10('W',-1));
      // Console.WriteLine(Case11('E',0,0));
    }

    static string Case1(int num)
    {
        switch (num)
        {
            case 1 :
                return("Monday");
                break;
            case 2 :
                return ("Tuesday");
                break;
            case 3 :
                return ("Wednesday");
                break;
            case 4 :
                return ("Thursday");
                break;
            case 5 :
                return ("friday");
                break;
            case 6 :
                return ("saturday");
                break;
            case 7 :
                return ("sunday");
                break;
        }
        return "error";
    }
    
    public static double Case7(int a, double b)
    {
        switch (a)
        {
            case 1:
                 return b;
                break;
            case 2:
                return (b * 0.000001);
                break;
            case 3:
                return (b * 0.001);
                break;
            case 4:
                return (b * 1000);
                break;
            case 5:
                return (b * 100);
                break;
        }
        return 0;
    }
    
    public static int Case8(int d, int m)
    {
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        int day = daysInMonth[m - 1];
        return day;
    }
    
    public static (int d,int m) Case9(int d, int m)
    {
        return (d+1,m);
    }
    
    public char Case10(char currentDirection, int command)
    {
        char[] directions = { 'N', 'E', 'S', 'W' };
        
        int currentIndex = Array.IndexOf(directions, currentDirection);
        int newIndex = (currentIndex + command + 4) % 4;

        return directions[newIndex];
    }
    
    public char Case11(char currentDirection, int command1,int command2)
    {
        char[] directions = { 'N', 'E', 'S', 'W' };
        
        int currentIndex = Array.IndexOf(directions, currentDirection);
        int newIndex = (currentIndex + (command1 + command2 + 4)) % 4;;

        return directions[newIndex];
    }
}
