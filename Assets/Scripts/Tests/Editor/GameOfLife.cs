namespace Tests.Editor
{
    public class GameOfLife
    {
        private readonly bool[,] _currentState;
        
        public GameOfLife(bool[,]initialState)
        {
            _currentState = initialState;
        }
        
        public bool[,] AdvanceToNextGeneration()
        {
            return _currentState;
        }
    }
}