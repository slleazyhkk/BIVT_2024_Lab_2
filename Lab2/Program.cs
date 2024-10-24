using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(0.9, 1.23);
        //program.Task_1_2(0.9, 1.23);
        //program.Task_1_3(0.9, 1.23);
        //program.Task_1_4(0.9, 1.23, -0.1);
        //program.Task_1_5(0.9, 1.23);
        //program.Task_1_6(0.9, 1.23);
        //program.Task_1_7(0.9);
        //program.Task_1_8(0.9);
        //program.Task_1_9(0.9);
        //program.Task_1_10(0.9);
        //program.Task_2_1(10);
        //program.Task_2_2(5, 3, 2, 1);
        //program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_3(10);
        //program.Task_2_4(5, 1, 2);
        //program.Task_2_5(10, 30);
        //program.Task_2_6(5);
        //program.Task_2_7(5);
        //program.Task_2_8(5);
        //program.Task_2_9(10);
        //program.Task_2_10(10);
        //program.Task_2_11(10);
        //program.Task_2_12(10, 0);
        //program.Task_2_13(10, 5, 0);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_3();
        //program.Task_3_4(1, 2);
        //program.Task_3_5(30);
        //program.Task_3_6();
        //program.Task_3_7();
        //program.Task_3_8();
        //program.Task_3_9();
        //program.Task_3_10();
        //program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        int r = 2;
        if (Math.Abs((x * x) + (y * y) - (r * r)) <= Math.Pow(10, -3))
        {
            answer = true;
        }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if ((y>=0)&((y+Math.Abs(x))<=1))
            answer= true;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a <= 0)
        {
            if (a < b)
            {
                answer = a;
            }
            else
            {
                answer = b;
            }
        }
        else
        {
            if (a > b)
            {
                answer = a;
            }
            else
            {
                answer = b;
            }
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        if (a < b)
        {
            if (a > c)
            {
                answer = a;
            }
            else
                answer = c;
        }
        else
        {
            if (b > c)
            {
                answer = b;
            }
            else
                answer = c;
        }

        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (2*(Math.Pow(r / 3.14, 0.5)) >= (Math.Pow(s * 2, 0.5)))
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (2 * (Math.Pow(r / 3.14, 0.5)) <= (Math.Pow(s, 0.5)))
            answer = true;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1)
        {
            answer = 1;
        }
        else
        {
            answer = Math.Abs(x);
        }

        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x)>=1)
        {
            answer = 0;
        }
        else
        {
            answer = x * x - 1;
        }

        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 0;
        if ((x>-1) & (x <= 0))
            answer = 1+x;
        if (x>0)
            answer = 1;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 1;
        if ((x > -1) & (x <= 1))
            answer = -x;
        if (x > 1)
            answer = -1;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        int cnt = 0;
        double answer = 0;
        // code here
        double w;
        double s = 0;

        while (cnt<n)
        {
            cnt++;
            double.TryParse(Console.ReadLine(), out w);
            s += w;
        }
        answer = s / n;
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x, y;
        int cnt = 0;
        while (cnt<n)
        {
            cnt++;
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (((x - a) * (x - a) + (y - b) * (y - b)) <= r * r)
            {
                answer++;
            }
        }
        // end
        Console.WriteLine(answer);  

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        // code here

        double milk = 0.2;
        double weight;
        double minweight = 30;
        int cnt = 0;
        while (cnt < n)
        {
            cnt++;
            double.TryParse(Console.ReadLine(), out weight);
            if (weight< minweight)
            {
                answer += milk;
            }

        }
        Console.WriteLine(answer);
        

        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        int cnt = 0;
        double x, y;
        while (cnt < n)
        {
            cnt++;
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x*x + y*y >= r1*r1 && x*x+ y*y <= r2*r2) answer++;

        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        // code here
        double a;
        int cnt = 0;
        while(cnt < n)
        {
            cnt++;
            double.TryParse(Console.ReadLine(), out a);
            if (a>=norm) answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        double x, y;

        // code here
        while (n > 0)
        { 
            n--;
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        double x, y;
        while (n > 0)
        {
            n--;
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x>0 && y > 0)
            {
                answer1++;
            }
            if (x<0 && y < 0)
            {
                answer3++; 
            }
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);

        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        // code here
        int number = 0;
        double x, y, x0, y0;
        while (number<n)
        {
            number++;
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (Math.Sqrt(x*x + y*y) < answerLength)
            {
                x0 = x;
                y0 = y;
                answerLength=Math.Sqrt(x*x + y*y);
                answer = number;
            }
        }
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);

        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double way = 200;
        double time;
        double best = 0;
        while (n > 0)
        {
            n--;
            double.TryParse(Console.ReadLine(), out way);
            if (way > best)
            {
                best = way;
            }
        }
        answer = best;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int o1, o2, o3, o4;
        while(n > 0)
        {
            n--;
            int.TryParse(Console.ReadLine(), out o1);
            int.TryParse(Console.ReadLine(), out o2);
            int.TryParse(Console.ReadLine(), out o3);
            int.TryParse(Console.ReadLine(), out o4);
            if (o1!=2 && o2!=2 && o3!=2 && o4!=2 && o1!=3 && o2!=3 && o3!=3 && o4 != 3)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        double s = 0;
        // code here;
        int cnt = 0;
        int o1, o2, o3, o4;
        while (cnt<n)
        {
            cnt++;
            int.TryParse(Console.ReadLine(), out o1);
            int.TryParse(Console.ReadLine(), out o2);
            int.TryParse(Console.ReadLine(), out o3);
            int.TryParse(Console.ReadLine(), out o4);
            s = s + (o1 + o2 + o3 + o4);
            if (o1 <= 2 || o2 <= 2 || o3 <= 2 || o4 <= 2)
            {
                answer++;
            }
        }
        avg = s/(n*4);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r <= 0) return 0;
        switch (type)
        {
            case 0:
                answer = r*r;
                break;
            case 1:
                answer = Math.PI * r * r;
                break;
            case 2:
                answer = r * r * Math.Sqrt(3) / 4;
                break;

        }

        // end

        return Math.Round(answer,2);
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A <= 0||B<=0) return 0;
        switch (type)
        {
            case 0:
                answer = A*B;
                break;
            case 1:
                answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                break;
            case 2:
                answer = Math.Sqrt((A / 2 + B) * (A / 2 + B - A) * (A*A / 4));
                break;
        }

        // end

        return Math.Round(answer,2);
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;

        // code here
        double r, s = 0;
        for (; ; n++)
        {
            double.TryParse(Console.ReadLine(), out r);
            if (r <= 0) break;
            s = s + r;
        }
        answer = s / n;
        Console.WriteLine(answer);
        // end

        // answer should be equal to the task_2_1 answer
        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;
        double x, y;

        // code here

        while(true)
        {
            if (!double.TryParse(Console.ReadLine(), out x)) break;
            if (!double.TryParse(Console.ReadLine(), out y)) break;
            if (x * x + y * y >= r1 * r1 && x * x + y * y <= r2 * r2) answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here
        double x, y;
        while (true)
        {
            if (!Double.TryParse(Console.ReadLine(),out x)) break;
            if (!Double.TryParse(Console.ReadLine(),out y)) break;
            if (x > 0 && y > 0)
            {
                answer1++;
            }
            if (x < 0 && y < 0)
            {
                answer3++;
            }
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here

        // end

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;
        int o1, o2, o3, o4;
        // code here;

        while (true)
        {
            if (!int.TryParse(Console.ReadLine(),out o1)) break;
            if (!int.TryParse(Console.ReadLine(), out o2)) break;
            if (!int.TryParse(Console.ReadLine(),out o3)) break;
            if (!int.TryParse(Console.ReadLine(),out o4)) break;
            if (o1!=2 && o2!=2 && o3!=2 && o4!=2 && o1 != 3 && o2 != 3 && o3 != 3 && o4 != 3) answer++;

        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;

        // end

        return (answer, avg);
    }
    #endregion
}
