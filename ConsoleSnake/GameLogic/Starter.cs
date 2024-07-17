namespace ConsoleSnake.GameLogic
{
    internal static class Starter
    {
        public static async Task GameStart()
        {
            while (!Snake.Snake.IsDead == true)
            {
                Task.Run(() => InputConverter.ConvertInput(Console.ReadKey()));
                Writer.WriteAllElement();
                Snake.Snake.SnakeMove();
                Thread.Sleep(100);
            }
        }
    }
}
