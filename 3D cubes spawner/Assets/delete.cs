using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour
{
    private Vector3 currentPos, startPos;
    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        startPos = gameObject.transform.position;
    }
    public void updateDistance(float distance)
    {
        this.distance = distance;
    }
    public void updateSpeed(Vector3 speed)
    {
        gameObject.GetComponent<Rigidbody>().velocity = speed;
    }
    // Update is called once per frame
    void Update()
    {
        currentPos = gameObject.transform.position; ;
        Debug.Log(Vector3.Distance(currentPos, startPos));
        Debug.Log(distance);
        if (Mathf.Abs(Vector3.Distance(currentPos, startPos)) >= distance)
        {
            Destroy(gameObject);
        }
    }
}
