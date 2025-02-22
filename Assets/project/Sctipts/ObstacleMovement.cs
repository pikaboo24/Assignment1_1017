using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float MoveSpeed = 4f;
    public float range = 20;
    public float distanceTravelled = 0;

 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forwardvector = transform.right;

        transform.position = transform.position + forwardvector * Time.deltaTime * MoveSpeed;
        distanceTravelled += MoveSpeed * Time.deltaTime;
        
        if(distanceTravelled > range)

        {
            Destroy(gameObject);
        }

    }
}
