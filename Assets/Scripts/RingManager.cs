using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RingManager : MonoBehaviour
{
    public float timeRemaining = 300;
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
        for (int i = 0; i < totalRingNum; i++)
        { //create loop. will do spawning 10 times
          // spawn a ring in the same position as the manager

            randPos.x = Random.Range(-30, 30); //random number
            randPos.y = Random.Range(5, 31);  // random number
            randPos.z = Random.Range(-30, 30);// random number
            Instantiate(ring, transform.position + randPos, transform.rotation * Quaternion.Euler(Vector3.up * Random.Range(0, 360)));
        }
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
    }
}