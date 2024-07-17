using ConsoleSnake.GameLogic;

namespace ConsoleSnake.Food
{
    internal class Food
    {
        public static byte CountFood { get; set; } = 0;
        private static List<Food> AllFood { get; set; } = new List<Food>();
        public static char FoodSymbol { get; } = 'O';
        private Position CurrentPosition { get; set; }
        public Food(Position position)
        {
            CurrentPosition = position;
            AllFood.Add(this);
            CountFood = (byte)AllFood.Count();
        }
        public static void DestroyFood(Food? food = null)
        {
            if (CountFood > 0)
            {
                if (food != null)
                    AllFood.Remove(food);
                else
                    AllFood.RemoveAt(0);
                CountFood = (byte)AllFood.Count();
            }
        }
        public Position GetFoodPosition()
        {
            return CurrentPosition;
        }
        public static List<Food> GetAllFood()
        {
            return AllFood;
        }
    }
}
