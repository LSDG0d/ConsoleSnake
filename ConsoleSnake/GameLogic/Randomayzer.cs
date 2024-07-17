namespace ConsoleSnake.GameLogic
{
    internal static class Randomayzer
    {
        public static Position GetRandomPosition()
        {
            Random random = new Random();
            return new Position((byte)random.Next(0, Map.Map.Weidth), (byte)random.Next(0, Map.Map.Height));
        }
    }
}
