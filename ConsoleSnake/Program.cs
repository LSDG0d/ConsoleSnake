using ConsoleSnake.GameLogic;

internal class Program
{
    private static async Task Main(string[] args)
    {
        Console.CursorVisible = false;
        await Starter.GameStart();
        Console.Clear();
        Console.WriteLine("You dead.\n :(");
        Console.ReadKey();
    }
}