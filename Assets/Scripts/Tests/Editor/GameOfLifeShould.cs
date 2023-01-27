using NUnit.Framework;

namespace Tests.Editor
{
    public class GameOfLifeShould
    {
        [Test]
        public void CreateAGridWithAnInitialState()
        {
            bool[,] initialState = null;
            var gameOfLife = GivenAGameOfLife(initialState);
            
            var currentState = WhenAdvanceToNextGeneration(gameOfLife);
            
            ThenCurrentStateIs(currentState, initialState);
        }

        private GameOfLife GivenAGameOfLife(bool[,] initialState)
        {
            return new GameOfLife(initialState);
        }

        private bool[,] WhenAdvanceToNextGeneration(GameOfLife gameOfLife)
        {
            return gameOfLife.AdvanceToNextGeneration();
        }

        private void ThenCurrentStateIs(bool[, ]currentState, bool[,]expectedState)
        {
            Assert.AreEqual(expectedState, currentState);
        }
        
    }
}
