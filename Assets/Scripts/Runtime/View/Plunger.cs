using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plunger : MonoBehaviour
{
    float chargedForce = 0;
    float maxForce = 2000f;

    private void OnTriggerStay(Collider other)
    {
        Rigidbody ballRigidbody = other.gameObject.GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.Space))
        {
            if (chargedForce < maxForce)
            {
                chargedForce += 400f * Time.deltaTime;
                Debug.Log(chargedForce);
            }
            else
                chargedForce = maxForce;
        }
        else
        {
            ballRigidbody.AddForce(new Vector3(0, 0, chargedForce));
            chargedForce = 0;
        }
    }
}
