using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plunger : MonoBehaviour
{
    private Pinball pinball;
    private float chargedForce = 0f;
    private Rigidbody ballRigidbody;

    private void Start()
    {
        pinball = FindObjectOfType<Dependencies>().Pinball;
    }

    private void Update()
    {
        if (KeepSpacePressed())
        {
            ChargePlunger();
        }

        if (ReleaseSpace())
        {
            Launch(ballRigidbody);
        }
    }

    private static bool ReleaseSpace()
    {
        return Input.GetKeyUp(KeyCode.Space);
    }

    private static bool KeepSpacePressed()
    {
        return Input.GetKey(KeyCode.Space);
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

    private void Launch(Rigidbody ballRigidbody)
    {
        if (ballRigidbody != null)
        {
            ballRigidbody.AddForce(Vector3.forward * chargedForce, ForceMode.Impulse);
        }
        chargedForce = 0f;
    }
}
