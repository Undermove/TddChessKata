using System;
using TddChessEngineLib;
using Xunit;

namespace TddChessEngineLibTests
{
    public class PawnTests
    {
        [Fact]
        public void WhenPawnTurnsFromE2ToE4_ThenItsPositionsChanges()
        {
            string startPosition = "E2";
            string finalPosition = "E4";
            Pawn pawn = new Pawn(startPosition);

            pawn.Turn(startPosition, finalPosition);

            Assert.Equal(finalPosition, pawn.CurrentPosition);
        }
    }
}
