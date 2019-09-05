using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMe : MonoBehaviour {

    public float torque_x;
    public float torque_y;
    public float torque_z;
    GameObject me;
	// Use this for initialization
	void Start () {
        me = gameObject;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 torque = new Vector3(torque_x, torque_y, torque_z);
        me.GetComponent<Rigidbody>().AddRelativeTorque(torque);      
     }
}
