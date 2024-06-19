using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class DomainTests
{
    [Test]
    public void DefaultScoreIsZero()
    {
        Pinball pinball = new Pinball();
        Assert.AreEqual(0, pinball.Score);
    }
    [Test]
    public void testInitiateWithNonZeroScore()
    {
        Pinball pinball = new Pinball(3, 100);
        Assert.AreEqual(3, pinball.BallsRemaining);
        Assert.AreEqual(100, pinball.Score);
    }
    [Test]
    public void AddPointsToScore()
    {
        Pinball pinball = new Pinball();
        pinball.AddPoints(10);
        Assert.AreEqual(10, pinball.Score);
        pinball.AddPoints(100);
        Assert.AreEqual(110, pinball.Score);
    }
    [Test]
    public void HasNoBallInPlayByDefault()
    {
        Pinball pinball = new Pinball();
        Assert.IsFalse(pinball.HasBallInPlay);
    }
    [Test]
    public void HasBallInPlayWhenReleased()
    {
        Pinball pinball = new Pinball();
        pinball.ReleaseBall();
        Assert.IsTrue(pinball.HasBallInPlay);
    }
    [Test]
    public void HasNoBallInPlayWhenLosingBall()
    {
        Pinball pinball = new Pinball();
        pinball.ReleaseBall();
        pinball.LoseBall();
        Assert.IsFalse(pinball.HasBallInPlay);
    }
    [Test]
    public void NotGameOverByDefault()
    {
        Pinball pinball = new Pinball();
        Assert.IsFalse(pinball.GameOver());
    }
    [Test]
    public void NotGameOverWhenPlayingLastBall()
    {
        Pinball pinball = new Pinball();
        pinball.ReleaseBall();
        Assert.IsFalse(pinball.GameOver());
    }
    [Test]
    public void GameOverWhenLosingLastBall()
    {
        Pinball pinball = new Pinball();
        pinball.ReleaseBall();
        pinball.LoseBall();
        Assert.IsTrue(pinball.GameOver());
    }
    [Test]
    public void NotGameOverIfHasBallsRemainingWhenLosingBall()
    {
        Pinball pinball = new Pinball(3);
        pinball.ReleaseBall();
        pinball.LoseBall();
        Assert.IsFalse(pinball.GameOver());
    }
    [Test]
    public void CannotReleaseBallIfNoBallsRemaining()
    {
        Pinball pinball = new Pinball();
        pinball.ReleaseBall();
        Assert.IsFalse(pinball.CanReleaseBall());
    }
    [Test]
    public void CannotReleaseBallIfThereIsOneBallInPlay()
    {
        Pinball pinball = new Pinball(3);
        pinball.ReleaseBall();
        Assert.IsFalse(pinball.CanReleaseBall());
    }
    [Test]
    public void LosingBallDecreasesBallsRemaining()
    {
        Pinball pinball = new Pinball(3);
        pinball.ReleaseBall();
        pinball.LoseBall();
        Assert.AreEqual(2, pinball.BallsRemaining);
    }
}
