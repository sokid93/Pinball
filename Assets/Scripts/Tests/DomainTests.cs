using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class DomainTests
{
    [Test]
    public void testDefaultScore()
    {
        Pinball pinball = new Pinball();
        Assert.AreEqual(0, pinball.GetScore());
    }
    [Test]
    public void testInitiateWithNonZeroScore()
    {
        Pinball pinball = new Pinball(100);
        Assert.AreEqual(100, pinball.GetScore());
    }
    [Test]
    public void testAddingScore()
    {
        Pinball pinball = new Pinball();
        pinball.AddPoints(10);
        Assert.AreEqual(10, pinball.GetScore());
        pinball.AddPoints(100);
        Assert.AreEqual(110, pinball.GetScore());
    }
    [Test]
    public void asdasdfsadf()
    {
        Pinball pinball = new Pinball();
        Assert.IsFalse(pinball.HasBallInPlay());
    }
}
