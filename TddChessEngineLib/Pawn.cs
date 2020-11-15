using System;

namespace TddChessEngineLib
{
    public class Pawn
    {
        public string CurrentPosition { get; private set; }

        public Pawn(string initialPosition)
        {
            CurrentPosition = initialPosition;
        }

        public void Turn(string startPosition, string finalPosition)
        {
            if(startPosition == CurrentPosition)
            {
                CurrentPosition = finalPosition;
            }
            else
            {
                throw new ArgumentException($"Current position is {CurrentPosition} not {startPosition}");
            }
        }
    }
}
