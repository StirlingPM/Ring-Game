using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollector : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Collectable")
        {
            
            Destroy(other.gameObject);
            RingManager.collectedRingNum++;

            Debug.Log("You have collected " + RingManager.collectedRingNum + " rings.");
        }
        else
        {

        }
    }
}
