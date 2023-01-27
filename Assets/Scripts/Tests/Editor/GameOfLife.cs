namespace Tests.Editor
{
    public class GameOfLife
    {
        private readonly bool[,] _currentState;
        
        public GameOfLife(int rows, int columns)
        {
            _currentState = new bool[columns, rows];
        }
        
        public bool[,] AdvanceToNextGeneration()
        {
            return _currentState;
        }
    }
}