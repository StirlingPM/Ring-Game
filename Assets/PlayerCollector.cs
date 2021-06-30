using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollector : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Collectable")
        {
            Debug.Log("You have collected a " + other.name);
            Destroy(other.gameObject);
        }
        else
        {

        }
    }
}
