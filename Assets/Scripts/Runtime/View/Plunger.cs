using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plunger : MonoBehaviour
{
    float chargedForce = 0;
    Pinball pinball;

    private void Start()
    {
        pinball = FindObjectOfType<Dependencies>().pinball;
    }

    private void OnTriggerStay(Collider other)
    {
        Rigidbody ballRigidbody = other.gameObject.GetComponent<Rigidbody>();
        if (SpaceKeyPressed())
        {
            ChargePlunger();
        }
        else if (SpaceKeyReleased())
        {
            LaunchBall(ballRigidbody);
        }
    }

    private static bool SpaceKeyReleased()
    {
        return Input.GetKeyUp(KeyCode.Space);
    }

    private static bool SpaceKeyPressed()
    {
        return Input.GetKey(KeyCode.Space);
    }

    private void LaunchBall(Rigidbody ballRigidbody)
    {
        ballRigidbody.AddForce(new Vector3(0, 0, chargedForce));
        chargedForce = 0;
    }

    private void ChargePlunger()
    {
        if (HasNotReachMaxForce())
        {
            chargedForce += 400f * Time.deltaTime;
        }
        else
            chargedForce = pinball.PlungerMaxForce;
    }

    private bool HasNotReachMaxForce()
    {
        return chargedForce < pinball.PlungerMaxForce;
    }
}
