using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    [SerializeField] GameObject rightFlipper;
    [SerializeField] KeyCode tecla;

    private void Update()
    {
        if (Input.GetKey(tecla))
            rightFlipper.GetComponent<HingeJoint>().useMotor = true;

        else
        {
            rightFlipper.GetComponent<HingeJoint>().useMotor = false;
        }          
    }
}
