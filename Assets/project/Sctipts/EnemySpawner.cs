using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float spawnRate = 1f;
    [SerializeField] private GameObject[] enemyPrefabs;
    [SerializeField] private bool canSpawn = true;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator Spawner()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnRate);
        while (canSpawn)
        {
            yield return wait;
            int rand = Random.Range(0, enemyPrefabs.Length);
            GameObject enemyToSpawn = enemyPrefabs[rand];
            Instantiate(enemyToSpawn, transform.position, Quaternion.Euler(0, 0, -90));

        }
    }
}
