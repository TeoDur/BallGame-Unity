using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockSlope : MonoBehaviour
{
    public static bool unlocked;
    
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject)
        {
            unlocked = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject)
        {
            unlocked = false;
        }
    }
}
