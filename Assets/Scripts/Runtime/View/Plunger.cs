using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plunger : MonoBehaviour
{
    [SerializeField] GameObject ball;
    Rigidbody ballRigidbody;
    Pinball pinball;

    private void Start()
    {
        ballRigidbody = ball.GetComponent<Rigidbody>();
        pinball = FindObjectOfType<Dependencies>().pinball;
    }

    void Update()
    {
        
    }
}
