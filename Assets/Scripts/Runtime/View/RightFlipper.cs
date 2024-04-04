using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFlipper : MonoBehaviour
{
    [SerializeField] GameObject rightFlipper;

    private void Update()
    {
        if (Input.GetKey(KeyCode.L))
            rightFlipper.GetComponent<HingeJoint>().useMotor = true;

        else
        {
            rightFlipper.GetComponent<HingeJoint>().useMotor = false;
        }          
    }
}
