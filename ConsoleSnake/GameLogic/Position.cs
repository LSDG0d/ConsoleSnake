namespace ConsoleSnake.GameLogic
{
    internal struct Position
    {
        public byte x { get; set; }
        public byte y { get; set; }
        public Position(byte x, byte y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
