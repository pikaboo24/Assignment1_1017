using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerBulletSctipt : MonoBehaviour
{
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
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            audioManager.PlaySFX(audioManager.boom);
            audioManager.PlaySFX(audioManager.enemyDeath);
        }
    }
}
