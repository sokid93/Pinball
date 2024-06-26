using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    Pinball pinball;
    EarnPoints scoreController;

    private void Start()
    {
        pinball = FindObjectOfType<Dependencies>().Pinball;
        scoreController = FindObjectOfType<Dependencies>().ScoreController;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Ball"))
        {
            BumpBall(collision);
        }
    }

    private void BumpBall(Collision collision)
    {
        collision.gameObject.GetComponent<Rigidbody>().AddExplosionForce(pinball.BumpForce, collision.contacts[0].point, 2f, 0f, ForceMode.VelocityChange);
        scoreController.Earn(10);
    }
}
