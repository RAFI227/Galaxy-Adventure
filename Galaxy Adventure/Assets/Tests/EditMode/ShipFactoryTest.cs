using NUnit.Framework;
using UnityEngine;
using View;
using Service;

public class ShipFactoryTest
{
    private Factory ShipFactory;

    [Test]
    public void TestCreateGoodShip()
    {
        ShipFactory = new ShipFactory();
        Assert.AreEqual(new Ship(Side.Good), ShipFactory.CreateShip(Side.Good));
    }
}
