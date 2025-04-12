using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstMove : MonoBehaviour
{
    public float Speed = 3f;
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Speed * Time.deltaTime);
    }
}
