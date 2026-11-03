using System.Runtime.InteropServices;

// System.Console.WriteLine("Сколько студентов в группе? ");
// int studentsCount = int.Parse(Console.ReadLine());
// int[] grades = new int[studentsCount];
// int t = 0;
// for (int i = 0; i < grades.Length; i++) {
//     System.Console.WriteLine($"Оценка студента {i + 1}:");
//     grades[i] = int.Parse(Console.ReadLine());
//     t += grades[i];
// }

// foreach (int grade in grades)
// {
//     System.Console.WriteLine(grade);
// }
// System.Console.WriteLine(t/grades.Length);


int[] points = { 4, 7, 2, 9, 5 };
for (int i = 0; i < points.Length; i++)
{
    if (points[i] < 10)
    {
        points[i] = points[i] + 1;
    }
}

foreach (int point in points)
{
    System.Console.WriteLine(point);
}