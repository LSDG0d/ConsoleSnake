namespace ConsoleSnake.GameLogic
{
    internal static class GenerationFood
    {
        public static Food.Food? AddNew()
        {
            if (Food.Food.CountFood != 0)
            {
                return null;
            }
            Position position = Randomayzer.GetRandomPosition();
            while (Map.Map.MapContent[position.x, position.y] != Map.Map.MapSymbol)
            {
                position = Randomayzer.GetRandomPosition();
            }
            Food.Food food = new Food.Food(position);
            return food;
        }
    }
}
