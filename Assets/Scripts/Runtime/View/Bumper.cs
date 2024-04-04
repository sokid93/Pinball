using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    Pinball pinball;

    private void Start()
    {
        pinball = FindObjectOfType<Dependencies>().pinball;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Ball"))
        {
            Rigidbody ballRB = collision.rigidbody;
            ballRB.AddExplosionForce(1000, collision.contacts[0].point, 1);
            pinball.AddPoints(10);
        }
    }
}
