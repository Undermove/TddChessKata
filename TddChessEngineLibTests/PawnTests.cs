using System;
using TddChessEngineLib;
using Xunit;

namespace TddChessEngineLibTests
{
    public class PawnTests
    {
        [Fact]
        public void WhenWhitePawnTurnsFromE2ToE4_ThenItsPositionsChanges()
        {
            string startPosition = "E2";
            string finalPosition = "E4";
            Pawn pawn = new Pawn(startPosition, FigureColor.White);

            pawn.Turn(startPosition, finalPosition);

            Assert.Equal(finalPosition, pawn.CurrentPosition);
        }

        [Fact]
        public void WhenBlackPawnTriesGoBack_ThenItsCantGoBack()
        {
            string startPosition = "E7";
            string finalPosition = "E8";
            Pawn pawn = new Pawn(startPosition, FigureColor.Black);

            pawn.Turn(startPosition, finalPosition);

            Assert.Equal(startPosition, pawn.CurrentPosition);
        }
    }
}
