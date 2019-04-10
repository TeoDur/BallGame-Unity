using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public float Void;
    public float X, Y, Z;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.y < Void)
        {
            transform.position = new Vector3(X, Y, Z);
        }
    }
}
