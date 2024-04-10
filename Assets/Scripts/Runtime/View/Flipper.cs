using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    [SerializeField] GameObject flipper;
    [SerializeField] KeyCode activationKey;

    private void Update()
    {
        if (Input.GetKey(activationKey))
            flipper.GetComponent<HingeJoint>().useMotor = true;

        else
            flipper.GetComponent<HingeJoint>().useMotor = false;
    }
}
