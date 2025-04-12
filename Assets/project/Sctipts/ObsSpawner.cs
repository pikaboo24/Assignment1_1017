using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsSpawner : MonoBehaviour
{
    [SerializeField] private float spawnRate = 5f;
    [SerializeField] private GameObject[] ObsPrefabs;
    [SerializeField] private bool canSpawn = true;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ObstacleSpawner());
    }

    // Update is called once per frame
    void Update()
    {

    }
    private IEnumerator ObstacleSpawner()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnRate);
        while (canSpawn)
        {
            yield return wait;
            int rand = Random.Range(0, ObsPrefabs.Length);
            GameObject ObsToSpawn = ObsPrefabs[rand];
            Instantiate(ObsToSpawn, transform.position, Quaternion.identity);

        }
    }
}
