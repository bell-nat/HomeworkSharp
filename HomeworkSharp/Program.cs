

using HomeworkSharp.Core;
using HomeworkSharp.Core.Enums;

ApplicationHandler handler = new();
ModeEnum mode = handler.GetMode();
Console.WriteLine(mode);
HomeworkSharp.Task1.SubTask1.Handler task1 = new(mode);
task1.Start();