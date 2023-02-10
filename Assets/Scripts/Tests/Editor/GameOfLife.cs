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
            int neighbourCounter = 0;
            
            for (int i = 0; i < _currentState.GetLength(0); i++)
            {
                for (int j = 0; j < _currentState.GetLength(1); j++)
                {
                    if (!_currentState[i, j]) continue;

                    if (CheckNeighbourCellIsAlive(i - 1, j - 1))
                    {
                        neighbourCounter++;
                    }

                    if (CheckNeighbourCellIsAlive(i - 1, j))
                    {
                        neighbourCounter++;
                    }

                    if (CheckNeighbourCellIsAlive(i - 1, j + 1))
                    {
                        neighbourCounter++;
                    }

                    if (CheckNeighbourCellIsAlive(i, j - 1))
                    {
                        neighbourCounter++;
                    }

                    if (CheckNeighbourCellIsAlive(i, j))
                    {
                        neighbourCounter++;
                    }

                    if (CheckNeighbourCellIsAlive(i, j + 1))
                    {
                        neighbourCounter++;
                    }

                    if (CheckNeighbourCellIsAlive(i + 1, j - 1))
                    {
                        neighbourCounter++;
                    }

                    if (CheckNeighbourCellIsAlive(i + 1, j))
                    {
                        neighbourCounter++;
                    }

                    if (CheckNeighbourCellIsAlive(i + 1, j + 1))
                    {
                        neighbourCounter++;
                    }

                    if (neighbourCounter < 2)
                    {
                        _currentState[i, j] = false;
                    }
                }
            }
            return _currentState;
        }

        private int GetNumberOfNeighboursAlive(int i, int j)
        {
            for (int x = -1; x < 2; x++)
            {
                
            }

            return 0;
        }

        private bool CheckNeighbourCellIsAlive(int i, int j)
        {
            return !IsIndexOutOfBoundary(i, j) && _currentState[i, j];
        }

        private bool IsIndexOutOfBoundary(int i, int j)
        {
            return i < 0 || i >= _currentState.GetLength(0) || j < 0 || j >= _currentState.GetLength(1);
        }
    }
}