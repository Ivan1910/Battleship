using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Vsite.Oom.Battleship.Model
{
    [TestClass]
    public class TestShip
    {
        [TestMethod]
        public void ConstructorCreateShipFromSquaresProvided()
        {
            ship Ship = new ship(new List<Square> { new Square(1, 4), new Square(1, 5), new Square(1, 6) });
            Assert.IsTrue(Ship.squares.Contains(new Square(1, 4)));
            Assert.IsTrue(Ship.squares.Contains(new Square(1, 5)));
            Assert.IsTrue(Ship.squares.Contains(new Square(1, 6)));
        }
        [TestMethod]
        public void HitMethodOnFirstSquareReturnsHitResultHit()
        {
            {
                ship ship = new ship(new List<Square> { new Square(1, 4), new Square(1, 5), new Square(1, 6) });
                var result = ship.Hit(new Square(1, 5));
                Assert.AreEqual(HitResult.Hit, result);
            }
            {
                ship ship = new ship(new List<Square> { new Square(1, 4), new Square(1, 5), new Square(1, 6) });
                var result = ship.Hit(new Square(1, 4));
                Assert.AreEqual(HitResult.Hit, result);
            }
            {
                ship ship = new ship(new List<Square> { new Square(1, 4), new Square(1, 5), new Square(1, 6) });
                var result = ship.Hit(new Square(1, 6));
                Assert.AreEqual(HitResult.Hit, result);
            }
        }
        [TestMethod]
        public void HitMethodOnMissedSquareReturnsHitResultMissed()
        {

            ship ship = new ship(new List<Square> { new Square(1, 4), new Square(1, 5), new Square(1, 6) });
            var result = ship.Hit(new Square(2, 5));
            Assert.AreEqual(HitResult.Missed, result);

        }
        [TestMethod]
        public void HitMethodOnLastSquareReturnsHitResultSunken()
        {

            ship ship = new ship(new List<Square> { new Square(1, 4), new Square(1, 5), new Square(1, 6) });
            var result = ship.Hit(new Square(1, 5));
            result = ship.Hit(new Square(1, 4));
            result = ship.Hit(new Square(1, 6));
            Assert.AreEqual(HitResult.Sunken, result);

        }
    }
}

