using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSlope : MonoBehaviour
{
    private static bool moveSlope1, moveSlope2, moveSlope3;
    public float TX, TY, TZ;

    // Update is called once per frame
    void Update()
    {
        moveSlope1 = UnlockSlope.unlocked;
        moveSlope2 = UnlockSlope2.unlocked;
        moveSlope3 = UnlockSlope3.unlocked;

        if (moveSlope1 == true)
        {
            transform.position = new Vector3(TX, TY, TZ);
        }
        if (moveSlope2 == true)
        {
            transform.position = new Vector3(TX, TY, TZ);
        }
        if (moveSlope3 == true)
        {
            transform.position = new Vector3(TX, TY, TZ);
        }
        else transform.position = new Vector3(TX, TY - 1, TZ);
    }
}
