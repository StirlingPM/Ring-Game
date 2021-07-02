using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RingManager : MonoBehaviour
{
    float timeRemaining;
    public Text ringCounter;
    public Text WinMessage;
    public GameObject ring;
    Vector3 randPos;
    public int totalRingNum;
    public int howManyRings;
    int currentRingNum;

    public static int collectedRingnum;

    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = 300;
        collectedRingnum = 0;
        WinMessage.enabled = false;
        
        SpawnRing(howManyRings);
        currentRingNum = howManyRings;
    }

    // Update is called once per frame
    void Update()
    {
        ringCounter.text = collectedRingnum + "/" + currentRingNum;
        if (collectedRingnum >= totalRingNum && WinMessage.enabled == false)
        {
            timeRemaining -= Time.deltaTime;
            WinMessage.enabled = true;
        }
        else
        {
            WinMessage.enabled = false;
        }

        if (collectedRingnum == currentRingNum && collectedRingnum != totalRingNum)
        {
            SpawnRing(howManyRings);
            currentRingNum += howManyRings;
        }
    }

    void SpawnRing(int howMany)
    {
        GameObject lastRing = gameObject;
        for (int i = 0; i < howMany; i++)
        {
            randPos.x = Random.Range(0f, 0f); //random number
            randPos.y = Random.Range(-0f, 0f);  // random number
            randPos.z = Random.Range(1f, 2f);// random number
            GameObject theRing = Instantiate(ring, lastRing.transform.position + randPos, transform.rotation);
            //theRing.transform.LookAt(lastRing.transform.position);
            lastRing = theRing;
        }

    }



    



}