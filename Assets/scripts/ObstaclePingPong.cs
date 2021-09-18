using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePingPong : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
        Debug.Log("same direction");

    }

    private void OnTriggerEnter(Collider collision)
    {
        transform.Rotate(new Vector3(0,0,180)); 
        Debug.Log("reverse direction");
    }
}
