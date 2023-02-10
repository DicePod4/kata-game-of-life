using NUnit.Framework;

namespace Tests.Editor
{
    public class GameOfLifeShould
    {
        [Test]
        public void CreateAGridWithAnInitialState()
        {
            var initialState = new bool[4,4];
            var gameOfLife = GivenAGameOfLife(initialState);
            
            var currentState = WhenAdvanceToNextGeneration(gameOfLife);
            
            ThenCurrentStateIs(currentState, initialState);
        }

        [Test]
        public void HaveCellsDyingWithFewerThanTwoLiveNeighbours()
        {
            var initialState = new bool[,] 
                { { false, false, false, false }, 
                { false, true, false, false },
                { false, false, false, false },
                { false, false, false, false } };
            
            var expectedState = new bool[,] 
            { { false, false, false, false }, 
                { false, false, false, false },
                { false, false, false, false },
                { false, false, false, false } };
            

            var gameOfLife = GivenAGameOfLife(initialState);
            
            var currentState = WhenAdvanceToNextGeneration(gameOfLife);
            
            ThenCurrentStateIs(currentState, expectedState);
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
