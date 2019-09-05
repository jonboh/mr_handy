using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixAngularVelocity : MonoBehaviour
{
    public float maxAngularVel = Mathf.Infinity;

    void Start()
    {
        Rigidbody[] rigidbodies = FindObjectsOfType<Rigidbody>();
        foreach (Rigidbody rigidbody in rigidbodies)
        {
            rigidbody.maxAngularVelocity = maxAngularVel;
        }
    }
}
