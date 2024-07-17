namespace ConsoleSnake.GameLogic
{
    internal static class Writer
    {
        public static void WriteAllElement()
        {
            Console.Clear();
            WriteSnake();
            WriteFood();
            Map.Map.WriteMap();
        }
        public static void WriteFood()
        {
            if (Food.Food.CountFood == 0)
            {
                GenerationFood.AddNew();
            }
            Food.Food[] Foods = Food.Food.GetAllFood().ToArray();
            foreach (var food in Foods)
            {
                Position position = food.GetFoodPosition();
                Map.Map.MapContent[position.x, position.y] = Food.Food.FoodSymbol;
            }
        }
        private static void WriteSnake()
        {
            List<Position> snake = Snake.Snake.GetSnake();
            foreach (var position in snake)
            {
                Map.Map.MapContent[position.x, position.y] = Snake.Snake.SnakeSymbol;
            }
        }
    }
}
