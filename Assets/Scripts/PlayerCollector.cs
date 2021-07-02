using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollector : MonoBehaviour
{
    PhysicsMover characterMover;

    private void Start()
    {
        characterMover = GetComponent<PhysicsMover>();
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Collectable")
        {
            
            Destroy(other.gameObject);
            RingManager.collectedRingnum++;

            Debug.Log("You have collected " + RingManager.collectedRingnum + " rings.");

            DoubleMoveSpeed();
            Invoke("HalfMoveSpeed", 1);

        }
    }

    void DoubleMoveSpeed()
    {
        characterMover.movementSpeed *= 1.1f;
    }
    void HalfMoveSpeed()
    {
        characterMover.movementSpeed /= 1.1f;
    }
}
