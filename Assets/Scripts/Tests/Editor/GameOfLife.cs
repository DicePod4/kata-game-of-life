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
            int neighbourCounter;
            
            for (int i = 0; i < _currentState.GetLength(0); i++)
            {
                for (int j = 0; j < _currentState.GetLength(1); j++)
                {
                    if (_currentState[i, j])
                    {
                        if (_currentState[i - 1, j - 1])
                        {
                            
                        }
                            
                    }
                }
            }
            return _currentState;
        }
    }
}