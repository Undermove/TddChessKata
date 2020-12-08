using System;
using Xunit;
using TddChessEngineLib;

namespace TddChessEngineLibTests
{
    public class ElephantTests
    {
        // поправить тест, чтобы он заработал
        [Fact]
        public void JustCreatingElephantTest()
        {
            // Arrange
            // Act
            // создаём слона сейчас этот код просто не работает и подчёркнут красным, это нужно исправить
            Elephant elephant = new Elephant(); 

            //  Assert
            // проверяем что он создался
            Assert.NotNull(elephant);
        }

        [Fact]
        public void WhenCreatingElephantOnC1_ThenItCurrentPositionOnC1()
        {
            // Arrange
            // задаём слону стартовую позицию
            string elephantPosition = "C1";

            // Act
            // создаём слона на стартовой позиции
            Elephant elephant = new Elephant(elephantPosition);

            // Assert
            // проверяем, что позиция применилась
            Assert.Equal(elephantPosition, elephant.CurrentPosition);
        }

        [Fact]
        public void WhenCreatingElephantOnBBB_ThenItThrowsArgumentException()
        {
            // Arrange
            // задаём слону стартовую позицию
            string elephantIncorrectPosition = "BBB";

            // Act and Assert
            // проверяем, что конструктор выкидывает ошибку, если клетка не C1
            Assert.Throws<ArgumentException>(() => new Elephant(elephantIncorrectPosition));
        }

        [Fact]
        public void WhenElephantTurnsFromC1ToD2_ThenItChangesCurrentPosition()
        {
            // Arrange
            // задаём слону стартовую позицию
            string elephantStartPosition = "C1";
            string elephantEndPosition = "D2";
            Elephant elephant = new Elephant(elephantStartPosition);

            // Act and
            elephant.Turn(elephantEndPosition);

            //Assert
            // проверяем, что конструктор выкидывает ошибку, если клетка не C1
            Assert.Equal(elephantEndPosition, elephant.CurrentPosition);
        }

        [Fact]
        public void WhenElephantTurnsFromC1ToBBB_ThenItThrowsArgumentException()
        {
            // Arrange
            // задаём слону стартовую позицию
            string elephantStartPosition = "C1";
            string elephantEndPosition = "BBB";
            Elephant elephant = new Elephant(elephantStartPosition);

            // Act and
            elephant.Turn(elephantEndPosition);

            // Assert
            // написать проверку самому
        }

        [Fact]
        public void YourOwnTest()
        {
            // Arrange
            // задаём слону стартовую позицию
            string elephantStartPosition = "C1";
            string elephantEndPosition = "BBB";
            Elephant elephant = new Elephant(elephantStartPosition);

            // Act and
            elephant.Turn(elephantEndPosition);

            // Assert
            // написать проверку самому
        }
    }
}