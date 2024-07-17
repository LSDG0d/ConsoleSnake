namespace ConsoleSnake.GameLogic
{
    internal static class InputConverter
    {
        public static void ConvertInput(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.W:
                    Snake.Snake.SetCurrentDirection(Movements.MoveTo.up);
                    break;
                case ConsoleKey.A:
                    Snake.Snake.SetCurrentDirection(Movements.MoveTo.left);
                    break;
                case ConsoleKey.S:
                    Snake.Snake.SetCurrentDirection(Movements.MoveTo.down);
                    break;
                case ConsoleKey.D:
                    Snake.Snake.SetCurrentDirection(Movements.MoveTo.right);
                    break;
            }
        }
    }
}
