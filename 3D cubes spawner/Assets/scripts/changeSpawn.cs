using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeSpawn : MonoBehaviour
{
    public GameObject distance, spawnTime, speedX, speedY, speedZ;
    public GameObject Spawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void transfer()
    {
        try
        {
            float distanceVal = (float)Convert.ToDouble(distance.GetComponent<InputField>().text);
            float spawnTimeVal = (float)Convert.ToDouble(spawnTime.GetComponent<InputField>().text);
            float speedXVal = (float)Convert.ToDouble(speedX.GetComponent<InputField>().text);
            float speedYVal = (float)Convert.ToDouble(speedY.GetComponent<InputField>().text);
            float speedZVal = (float)Convert.ToDouble(speedZ.GetComponent<InputField>().text);
            Vector3 speed = new Vector3(speedXVal, speedYVal, speedZVal);
            Spawner.GetComponent<cubeSpawner>().updateStats(speed, distanceVal, spawnTimeVal);
        }
        catch(Exception)
        {
        }
    }
}
