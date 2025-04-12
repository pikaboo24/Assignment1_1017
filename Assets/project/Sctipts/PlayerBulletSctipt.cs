using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerBulletSctipt : MonoBehaviour
{
    public GameObject explosionPrefab;
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
        if (collision.CompareTag("Enemy"))
        {
            ScoreKeep.instance.AddScore(10);
            audioManager.PlaySFX(audioManager.boom2);
            audioManager.PlaySFX(audioManager.enemyDeath);

            Destroy(collision.gameObject);
            Destroy(gameObject);

            Instantiate(explosionPrefab, collision.transform.position, Quaternion.identity);
            
            
        }
        
        
    }
    
}
