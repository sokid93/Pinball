using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    ScoreController scoreController;

    private void Start()
    {
        scoreController = FindObjectOfType<Dependencies>().scoreController;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Ball"))
        {
            Rigidbody ballRB = collision.rigidbody;
            ballRB.AddExplosionForce(1000, collision.contacts[0].point, 1);
            scoreController.EarnPoints(10);
        }
    }
}
