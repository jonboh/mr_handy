using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StocasticForces : MonoBehaviour {

    GameObject me;

    public GameObject academy;

    private float stoca_torque;
    private float stoca_strenght;
    private float stoca_freq;
    private float stoca_stepcount;

    private float stepcount=0;
    private Vector3 force_vec = default(Vector3);
    private Vector3 torque_vec = default(Vector3);
    // Use this for initialization
    void Start ()
    {
        me = gameObject;
        stoca_torque = academy.GetComponent<HandAcademy>().stoca_torque;
        stoca_strenght = academy.GetComponent<HandAcademy>().stoca_strenght;
        stoca_freq = academy.GetComponent<HandAcademy>().stoca_freq;
        stoca_stepcount = academy.GetComponent<HandAcademy>().stoca_stepcount;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (stepcount == stoca_stepcount) { stepcount = 0; }
        if (stepcount > 0 && stepcount < stoca_stepcount)
        {
            me.GetComponent<Rigidbody>().AddRelativeForce(force_vec);
            me.GetComponent<Rigidbody>().AddRelativeTorque(torque_vec);
            stepcount += 1;
        }
        else
        {
            float aux = Random.Range(0.0f, 1.0f);
            if (aux < stoca_freq)
            {
                force_vec = new Vector3(Random.Range(-stoca_torque, +stoca_torque),
                            Random.Range(-stoca_torque, +stoca_torque),
                            Random.Range(-stoca_torque, +stoca_torque));
                torque_vec = new Vector3(Random.Range(-stoca_strenght, +stoca_strenght),
                            Random.Range(-stoca_strenght, +stoca_strenght),
                            Random.Range(-stoca_strenght, +stoca_strenght));
                me.GetComponent<Rigidbody>().AddRelativeForce(force_vec);
                me.GetComponent<Rigidbody>().AddRelativeTorque(torque_vec);
                stepcount += 1;
            }
        }
        
    }
}
