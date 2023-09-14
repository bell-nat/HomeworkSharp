using HomeworkSharp.Core;
using HomeworkSharp.Core.Enums;

namespace HomeworkSharp.Task1.SubTask1;

/// <summary>
/// Вычислить Y при введённом значении X по приведённой формуле и по
/// оптимизированной Вами формуле:
/// Y = 1 +
/// (X^2)/(3^2) + (X^2)/(7^2) + (X^2)/(11^2) +
/// (X^4)/(3^2*7^2) + (X^4)/(3^2*11^2) + (X^4)/(7^2*11^2) +
/// (X^6)/(3^2*7^2*11^2)
/// При X = { -4, 0, 4, 11 }
/// </summary>
public class Handler
{
    private ModeEnum _mode;
    private double[] _valuesDefault;

    public Handler(ModeEnum mode)
    {
        _mode = mode;
        _valuesDefault = new double[] { -4, 0, 4, 11 };
    }

    public void Start()
    {
        List<double> values = _mode switch
        {
            ModeEnum.Auto => _valuesDefault.ToList(),
            ModeEnum.Manual => new List<double> { ConsoleWrapper.GetDouble("Введите X") },
            _ => throw new Exception("Не определён режим запуска.")
        };

        values.ForEach(Calculation);
    }

    private void Calculation(double x)
    {
        double squared3 = Power(3, 2);
        double squared7 = Power(7, 2); 
        double squared11 = Power(11, 2); 

        double squaredX = Power(x, 2); 
        double powerXin4 = Power(x, 4);
        double powerXin6 = Power(x, 6);

        double y = 1 +
        Division(squaredX, squared3) +
        Division(squaredX, squared7) +
        Division(squaredX, squared11) +
        Division(powerXin4, squared3 * squared7) +
        Division(powerXin4, squared3 * squared11) +
        Division(powerXin4, squared7 * squared11) +
        Division(powerXin6, squared3 * squared7 * squared11);

        Console.WriteLine($"При\tX = {x}");
        Console.WriteLine($"\tY = {y}");
    }

    private double Division(double first, double second) => first / second;

    private double Power(double x, uint multy)
    {
        double result = multy is not 0 ? x : 1; 

        for (int i = 1; i < multy; i++)
        {
            result *= x;   
        }
        return result;
    }


}