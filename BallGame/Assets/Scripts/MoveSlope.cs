using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSlope : MonoBehaviour
{
    private static bool moveSlope;
    public float TX, TY, TZ;

    // Update is called once per frame
    void Update()
    {
        moveSlope = UnlockSlope.unlocked;

        if (moveSlope == true)
        {
            transform.position = new Vector3(TX, TY, TZ);
        }
        else transform.position = new Vector3(TX, TY - 1, TZ);
    }
}
