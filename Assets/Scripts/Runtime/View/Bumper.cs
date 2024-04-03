using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Ball"))
        {
            Rigidbody ballRB = collision.rigidbody;
            ballRB.AddExplosionForce(1000, collision.contacts[0].point, 1);
        }
    }
}
