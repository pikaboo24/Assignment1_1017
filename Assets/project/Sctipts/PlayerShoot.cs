using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject ProjectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Input.GetKey(KeyCode.Space);
        {
            Instantiate(ProjectilePrefab, transform.position , transform.rotation);

        }
    }
}
