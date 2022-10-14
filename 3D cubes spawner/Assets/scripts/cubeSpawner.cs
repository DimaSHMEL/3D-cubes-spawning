using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeSpawner : MonoBehaviour
{
    private new Vector3 speed;
    private float distance;
    private float spawnTime;
    public GameObject spawn;

    // Start is called before the first frame update
    void Start()
    {
    }
    IEnumerator spawnCube(float time)
    {
        while (true)
        {
            GameObject spawned = Instantiate(spawn, gameObject.transform);
            spawned.GetComponent<delete>().updateDistance(distance);
            spawned.GetComponent<delete>().updateSpeed(speed);
            yield return new WaitForSeconds(time);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void updateStats(Vector3 speed, float distance, float spawnTime)
    {
        this.speed = speed;
        this.distance = distance;
        this.spawnTime = spawnTime;
        startSpawning();
    }
   
    public void startSpawning()
    {
        StopAllCoroutines();
        StartCoroutine(spawnCube(spawnTime));  
    }
}
