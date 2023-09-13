using HomeworkSharp.Core.Enums;

namespace HomeworkSharp.Core;

public class ApplicationHandler
{
    public ModeEnum GetMode()
    {
        Console.WriteLine("Режимы запуска:");
        Console.WriteLine("1 - авто");
        Console.WriteLine("2 - ручной");

        ModeEnum mode;
        do
        {
            int digital = ConsoleWrapper.GetInt("Выберите режим запуска: ");
            mode = digital switch
            {
                1 => ModeEnum.Auto,
                2 => ModeEnum.Manual,
                _ => ModeEnum.Unknown,
            };
        } while (mode is ModeEnum.Unknown);

        return mode;
    }
}