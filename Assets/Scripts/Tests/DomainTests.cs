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
        Assert.AreEqual(0, pinball.score);
    }
    [Test]
    public void testInitiateWithNonZeroScore()
    {
        Pinball pinball = new Pinball(100);
        Assert.AreEqual(100, pinball.score);
    }
    [Test]
    public void testAddingScore()
    {
        Pinball pinball = new Pinball(0);
        pinball.AddPoints(10);
        Assert.AreEqual(10, pinball.score);
        pinball.AddPoints(100);
        Assert.AreEqual(110, pinball.score);
    }
}
