using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plunger : MonoBehaviour
{
    private Pinball pinball;
    private bool isCharging = false;
    private float chargedForce = 0f;
    private Rigidbody ballRigidbody;

    private void Start()
    {
        pinball = FindObjectOfType<Dependencies>().pinball;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isCharging = true;
            chargedForce = 0f;
        }

        if (Input.GetKey(KeyCode.Space) && isCharging)
        {
            ChargePlunger();
        }

        if (Input.GetKeyUp(KeyCode.Space) && isCharging)
        {
            isCharging = false;
            LaunchBall(ballRigidbody);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ballRigidbody = other.gameObject.GetComponent<Rigidbody>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ballRigidbody = null;
        }
    }

    private void ChargePlunger()
    {
        if (chargedForce < pinball.PlungerMaxForce)
        {
            chargedForce += Time.deltaTime * 4;
        }
        else
        {
            chargedForce = pinball.PlungerMaxForce;
        }
    }

    private void LaunchBall(Rigidbody ballRigidbody)
    {
        if (ballRigidbody != null)
        {
            ballRigidbody.AddForce(Vector3.forward * chargedForce, ForceMode.Impulse);
        }
        chargedForce = 0f;
    }
}
