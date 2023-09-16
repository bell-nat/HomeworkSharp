

using HomeworkSharp.Core;
using HomeworkSharp.Core.Enums;

HomeworkSharp.Task1.SubTask2.Handler task2 = new();
task2.Start();

ApplicationHandler handler = new();
ModeEnum mode = handler.GetMode();
Console.WriteLine(mode);
HomeworkSharp.Task1.SubTask1.Handler task1 = new(mode);
task1.Start();