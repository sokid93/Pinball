using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftFlipper : MonoBehaviour
{
    [SerializeField] GameObject leftFlipper;

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
            leftFlipper.GetComponent<HingeJoint>().useMotor = true;

        else
        {
            leftFlipper.GetComponent<HingeJoint>().useMotor = false;
        }          
    }
}
