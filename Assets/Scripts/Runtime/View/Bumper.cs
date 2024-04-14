using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    Pinball pinball;
    ScoreController scoreController;

    private void Start()
    {
        pinball = FindObjectOfType<Dependencies>().pinball;
        scoreController = FindObjectOfType<Dependencies>().scoreController;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Ball"))
        {
            Rigidbody ballRB = collision.rigidbody;
            ballRB.AddExplosionForce(pinball.BumpForce, collision.contacts[0].point, 1);
            scoreController.EarnPoints(10);
        }
    }
}
