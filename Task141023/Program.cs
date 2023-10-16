#region Rəqəmlərin yerin dəyiş.

int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
m = m + n;
n = m - n;
m = m - n;
Console.WriteLine(n);
Console.WriteLine(m);

#endregion
