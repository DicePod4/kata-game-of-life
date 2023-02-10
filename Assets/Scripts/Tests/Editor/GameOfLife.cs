using System;

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
            var updatedState = (bool[,])_currentState.Clone();
            
            for (var i = 0; i < _currentState.GetLength(0); i++)
            {
                for (var j = 0; j < _currentState.GetLength(1); j++)
                {
                    if (!_currentState[i, j]) continue;

                    var aliveNeighboursCount = GetNumberOfNeighboursAlive(i, j);
                    
                    if(aliveNeighboursCount < 2 ||aliveNeighboursCount > 3)
                        updatedState[i, j] = false;
                }
            }
            
            return updatedState;
        }

        private int GetNumberOfNeighboursAlive(int i, int j)
        {
            var neighbourCounter = 0;
            
            for (var x = -1; x < 2; x++)
            {
                for (var y = -1; y < 2; y++)
                {
                    if (x == 0 && y == 0)
                        continue;
                    
                    if (CheckNeighbourCellIsAlive(i + x, j + y))
                        neighbourCounter++;
                }
            }

            return neighbourCounter;
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