using ConsoleSnake.GameLogic;

namespace ConsoleSnake.Snake
{
    internal static class Snake
    {
        private static readonly Position StartPosition = new Position(Convert.ToByte((Map.Map.Weidth + 1) / 2), Convert.ToByte((Map.Map.Height + 1) / 2));
        private static Position CurrentPosition { get; set; } = StartPosition;
        public static bool IsDead { get; private set; } = false;
        private static ushort CurrentSize { get; set; } = 1;
        private static Movements.MoveTo CurrentDirection { get; set; } = Movements.MoveTo.left;
        public static char SnakeSymbol { get; } = '@';
        public static List<Position> TailPositions { get; private set; } = new List<Position>();
        private static bool OnCreated { get; set; } = false;
        public static void SetCurrentDirection(Movements.MoveTo move)
        {
            CurrentDirection = move;
        }
        private static void SnakeChangePosition()
        {
            byte y = CurrentPosition.y;
            byte x = CurrentPosition.x;
            switch (CurrentDirection)
            {
                case Movements.MoveTo.up:
                    y = CurrentPosition.y;
                    x = CurrentPosition.x;
                    CurrentPosition = new Position(x, --y);
                    break;
                case Movements.MoveTo.down:
                    y = CurrentPosition.y;
                    x = CurrentPosition.x;
                    CurrentPosition = new Position(x, ++y);
                    break;
                case Movements.MoveTo.left:
                    y = CurrentPosition.y;
                    x = CurrentPosition.x;
                    CurrentPosition = new Position(--x, y);
                    break;
                case Movements.MoveTo.right:
                    y = CurrentPosition.y;
                    x = CurrentPosition.x;
                    CurrentPosition = new Position(++x, y);
                    break;
            }
        }
        public static void SnakeMove()
        {
            SnakeChangePosition();
            if (CurrentPosition.x >= 0 && CurrentPosition.x < Map.Map.Weidth && CurrentPosition.y >= 0 && CurrentPosition.y < Map.Map.Height && IsDead == false)
            {
                UpdateTailPosition();
            }
            else
            {
                IsDead = true;
            }
        }

        private static void UpdateTailPosition()
        {
            if (Map.Map.MapContent[CurrentPosition.x, CurrentPosition.y] == Snake.SnakeSymbol)
            {
                IsDead = true ;
                return;
            }
            bool IsEating = false;
            if (Map.Map.MapContent[CurrentPosition.x, CurrentPosition.y] == Food.Food.FoodSymbol)
            {
                IsEating = true ;
            }
            TailPositions.Add(CurrentPosition);
            Map.Map.MapContent[TailPositions[0].x, TailPositions[0].y] = Map.Map.MapSymbol;
            TailPositions.RemoveAt(0);
            if (IsEating)
            {
                Snake.SnakeEat();
                Food.Food.DestroyFood();
            }
        }

        public static void SnakeEat()
        {
            CurrentSize++;
            TailPositions.Add(CurrentPosition);
            return;
        }
        public static void CreateSnake()
        {
            if (!OnCreated)
            {
                TailPositions.Add(CurrentPosition);
                OnCreated = true;
            }
            else
            {
                return;
            }
        }
        public static List<Position> GetSnake()
        {
            if (!OnCreated)
            {
                CreateSnake();
            }
            return TailPositions;
        }
    }
}
