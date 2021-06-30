using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingManager : MonoBehaviour
{
    public GameObject ring;
    Vector3 randPos;
    public int totalRingNum = 100;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < totalRingNum; i++)
        {
            randPos.x = Random.Range(-200, 200);
            randPos.y = Random.Range(0, 50);
            randPos.z = Random.Range(-200, 200);

            //spawn a ring in the same position as the manager
            Instantiate(ring,transform.position + randPos,transform.rotation * Quaternion.Euler(Vector3.up * Random.Range(0, 360)));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
