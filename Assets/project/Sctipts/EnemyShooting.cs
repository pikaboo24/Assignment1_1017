using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;

    private float timer;
    AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer>2)
        {
            timer = 0;
            shoot();
        }
    }
    void shoot()
    {
        audioManager.PlaySFX(audioManager.enemyShoot);
        Instantiate(bullet, bulletPos.position, Quaternion.identity);   
    }
}
