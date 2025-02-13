using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float MoveSpeed = 4f;
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(MoveSpeed, 0, 0) * Time.deltaTime;

    }
}
