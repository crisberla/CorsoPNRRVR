using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kunaihandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rigidbody = GetComponent<EigidBody>();
        rigidbody.AddForce(transform.foreward*5,ForceMode.VelocityChange)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
