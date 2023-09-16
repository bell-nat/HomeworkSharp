using HomeworkSharp.Core;

namespace HomeworkSharp.Task1.SubTask2;

/*
Вариант №4. Вычислить S – площадь остроугольного треугольника по формуле S = (La*Lb*sin(C))/2
, где La и Lb – длины сторон, а С – угол между ними. Затем вычислить
длину третьей стороны Lc, используя соотношение Lc2=La2+Lb2 -2·La·Lb·cosC и остальные
углы, используя соотношение sinA/sinC=La/Lc. Проверить результаты для различных
исходных данных по сумме углов.
*/
public class Handler
{
    public void Start()
    {
        // Введите длины сторон La и Lb и угол C в градусах
        double lA = ConsoleWrapper.GetDouble("Введите длину стороны La:");
        double lB = ConsoleWrapper.GetDouble("Введите длину стороны Lb:");
        double cDegrees = ConsoleWrapper.GetDouble("Введите угол C в градусах:"); ;

        // Переведем угол C из градусов в радианы
        double cRadians = Math.PI * cDegrees / 180.0;

        // Вычисляем площадь S по формуле
        double s = (lA * lB * Math.Sin(cRadians)) / 2.0;

        // Вычисляем длину третьей стороны Lc по формуле
        double lCSquared = lA * lA + lB * lB - 2 * lA * lB * Math.Cos(cRadians);
        double lC = Math.Sqrt(lCSquared);

        // Вычисляем угол A
        double aRadians = Math.Asin((lA * Math.Sin(cRadians)) / lC);
        double aDegrees = aRadians * 180.0 / Math.PI;

        // Вычисляем угол B
        double bDegrees = 180.0 - aDegrees - cDegrees;

        // Выводим результаты
        Console.WriteLine($"Площадь треугольника S: {s}");
        Console.WriteLine($"Длина третьей стороны Lc: {lC}");
        Console.WriteLine($"Угол A: {aDegrees} градусов");
        Console.WriteLine($"Угол B: {bDegrees} градусов");
    }
}