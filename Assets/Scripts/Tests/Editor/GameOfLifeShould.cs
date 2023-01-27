using NUnit.Framework;

namespace Tests.Editor
{
    public class GameOfLifeShould
    {
        [TestCase(1, 1)]
        [TestCase(10, 10)]
        [TestCase(100, 100)]
        public void CreateAGridOfGivenSize(int rows, int columns)
        {
            var gameOfLife = GivenAGameOfLife(rows, columns);
            
            var currentState = WhenAdvanceToNextGeneration(gameOfLife);
            
            ThenItWillHaveAGridWithTheGivenSize(currentState, rows, columns);
        }
        
        private GameOfLife GivenAGameOfLife(int rows, int columns)
        {
            return new GameOfLife(rows, columns);
        }

        private bool[,] WhenAdvanceToNextGeneration(GameOfLife gameOfLife)
        {
            return gameOfLife.AdvanceToNextGeneration();
        }
        
        private void ThenItWillHaveAGridWithTheGivenSize(bool[,] currentState, int rows, int columns)
        {
            Assert.AreEqual(columns, currentState.GetLength(0));
            Assert.AreEqual(rows, currentState.GetLength(1));
        }
    }
}
