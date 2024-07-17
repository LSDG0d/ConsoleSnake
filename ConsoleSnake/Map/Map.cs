namespace ConsoleSnake.Map
{
    internal static class Map
    {
        public static byte Height { get; } = 20;
        public static byte Weidth { get; } = 40;
        public static char MapSymbol { get; } = '.';
        public static char[,] MapContent { get; set; } = GenerateMap();
        private static char[,] GenerateMap()
        {
            char[,] result = new char[Weidth, Height];
            for (byte i = 0; i < Height; i++)
            {
                for (byte j = 0; j < Weidth; j++)
                {
                    result[j, i] = MapSymbol;
                }
            }
            return result;
        }
        public static void WriteMap()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (byte i = 0; i < Height; i++)
            {
                Console.Write("\t\t\t");
                for (byte j = 0; j < Weidth; j++)
                {
                    Console.Write(MapContent[j, i]);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
