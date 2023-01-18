using System;
public class MainClass
{
    public static void Main()
    {
        double AB, AC, DC, BC, BD,result;

        double CalculateTheHypotenuse(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }

        double CalculateThePerimeter(double AB, double AC,double CD,double BD)
        {
            return AB + AC + CD + BD;
        }   
        
        Console.WriteLine("Введите стороны:AB,AC,DC");
        Console.Write("AB=");
        AB = double.Parse(Console.ReadLine());
        Console.Write("AC=");
        AC = double.Parse(Console.ReadLine());
        Console.Write("DC=");
        DC = double.Parse(Console.ReadLine());

        BC = CalculateTheHypotenuse(AB, AC);
        BD = CalculateTheHypotenuse(BC, DC);
        
        result=CalculateThePerimeter((double) AB, (double) AC,(double) BC, (double) BD);

        Console.WriteLine("Периметр фигуры:"+ result);



    }
}
