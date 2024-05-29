using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    [SerializeField] GameObject flipper;
    [SerializeField] KeyCode activationKey;

    Pinball pinball;

    private void Start()
    {
        pinball = FindObjectOfType<Dependencies>().Pinball;
    }


    private void Update()
    {
        if (!pinball.GameOver())
        {
            if (Input.GetKey(activationKey))
                flipper.GetComponent<HingeJoint>().useMotor = true;
            else
                flipper.GetComponent<HingeJoint>().useMotor = false;
        } 
    }
}
