using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RingManager : MonoBehaviour
{
    float timeRemaining = 300;
    public Text ringCounter;
    public Text WinMessage;
    public GameObject ring;
    Vector3 randPos;
    public int totalRingNum = 10;
    public static int collectedRingnum;

    // Start is called before the first frame update
    void Start()
    {
        WinMessage.enabled = false;
        SpawnRing(totalRingNum);
    }

    // Update is called once per frame
    void Update()
    {
        ringCounter.text = collectedRingnum + "/" + totalRingNum;
        if (collectedRingnum >= totalRingNum && WinMessage.enabled == false)
        {
            timeRemaining -= Time.deltaTime;
            WinMessage.enabled = true;
        }
        else
        {
            WinMessage.enabled = false;
        }

        if (collectedRingnum == totalRingNum)
        {
            SpawnRing(5);
            totalRingNum += (5);
        }
    }

    void SpawnRing(int howMany)
    {

        for (int i = 0; i < howMany; i++)
        {
            randPos.x = Random.Range(0, 100); //random number
            randPos.y = Random.Range(0f, 2f);  // random number
            randPos.z = Random.Range(0, 100);// random number
            Instantiate(ring, transform.position + randPos, transform.rotation * Quaternion.Euler(Vector3.up * Random.Range(0, 0)));
        }

    }
}