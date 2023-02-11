using Tasc_10._6;
double AB, AC, DC, BC, BD, result;
Console.WriteLine("Введите стороны:AB,AC,DC");
Console.Write("AB=");
AB = double.Parse(Console.ReadLine());
Console.Write("AC=");
AC = double.Parse(Console.ReadLine());
Console.Write("DC=");
DC = double.Parse(Console.ReadLine());

BC = Class1.CalculateTheHypotenuse(AB, AC);
BD = Class1.CalculateTheHypotenuse(BC, DC);

result = Class1.CalculateThePerimeter((double)AB, (double)AC, (double)BC, (double)BD);

Console.WriteLine("Периметр фигуры:" + result);

