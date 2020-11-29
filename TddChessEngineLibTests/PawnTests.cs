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

            Assert.Throws<ArgumentException>(() => pawn.Turn(startPosition, finalPosition));
        }

        [Fact]
        public void WhenWhitePawnTriesGoBack_ThenItsCantGoBack()
        {
            string startPosition = "E2";
            string finalPosition = "E1";

            Pawn pawn = new Pawn(startPosition, FigureColor.White);

            Assert.Throws<ArgumentException>(() => pawn.Turn(startPosition, finalPosition));
        }

        [Fact]
        public void WhenWhitePawnTurnsFromE3ToE5_ThenItsCantJump()
        {
            string startPosition = "E3";
            string finalPosition = "E5";

            Pawn pawn = new Pawn(startPosition, FigureColor.White);

            Assert.Throws<ArgumentException>(() => pawn.Turn(startPosition, finalPosition));
        }
    }
}
