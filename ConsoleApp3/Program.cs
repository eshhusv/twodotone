Console.Write("Введите x: ");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите y: ");
double y = double.Parse(Console.ReadLine());

if (x <= 0 && x >= -1 && y >= 0 && y <= 1) Console.WriteLine(GetTopLeftSolution());
else if (x >= 0 && x <= 1 && y >= 0 && y <= 1) Console.WriteLine(GetTopRightSolution());
else if (x <= 0 && x >= -1 && y <= 0 && y >= -1) Console.WriteLine(GetBottomLeftSolution());
else if (x >= 0 && x <= 1 && y <= 0 && y >= -1) Console.WriteLine(GetBottomRightSolution());
else if (x == 0 && y ==0) Console.WriteLine(GetZeroSolution());

string GetTopLeftSolution()
{
    if (x >= -1 && x <= 0 && y >= 0 && y >= 1 - x * Math.Abs((y - 1)) && y <= 1) return "Попадает";
    else return "Не попадает";
};
string GetTopRightSolution()
{
    if (x <= 1 && x >= 0 && y >= 0 && y >= 1 - x * Math.Abs((y - 1)) && y <= 1) return "Попадает";
    else return "Не попадает";
};
string GetBottomLeftSolution()
{
    if (x >= -1 && x <= 0 && y >= -1 && y <= 1 - x * Math.Abs((y - 1)) && y <= 0) return "Попадает";
    else return "Не попадает";
};
string GetBottomRightSolution()
{
    if (x <= 1 && x >= 0 && y >= -1 && y >= 1 - x * Math.Abs((y - 1)) && y <= 1) return "Попадает";
    else return "Не попадает";
};

string GetZeroSolution()
{
    return "Не попадает";
}