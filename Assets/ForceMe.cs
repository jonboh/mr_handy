using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceMe : MonoBehaviour
{

    public float force_x;
    public float force_y;
    public float force_z;
    GameObject me;
    // Use this for initialization
    void Start()
    {
        me = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 force = new Vector3(force_x, force_y, force_z);
        me.GetComponent<Rigidbody>().AddRelativeForce(force);
    }
}
