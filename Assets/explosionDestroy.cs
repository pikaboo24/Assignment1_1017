using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionDestroy : MonoBehaviour
{
    public float delay = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, delay);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
