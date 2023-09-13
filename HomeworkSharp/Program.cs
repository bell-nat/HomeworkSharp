//Вычислить Y при введённом значении X по приведённой формуле и по
// оптимизированной Вами формуле:
// Y = 1 +
// (X^2)/(3^2) + (X^2)/(7^2) + (X^2)/(11^2) +
// (X^4)/(3^2*7^2) + (X^4)/(3^2*11^2) + (X^4)/(7^2*11^2) +
// (X^6)/(3^2*7^2*11^2)
// При X = { -4, 0, 4, 11 }

using HomeworkSharp.Core;
using HomeworkSharp.Core.Enums;

ApplicationHandler handler = new();
ModeEnum mode = handler.GetMode();
Console.WriteLine(mode);