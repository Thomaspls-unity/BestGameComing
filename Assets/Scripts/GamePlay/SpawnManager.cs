using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] itemsToSpawn;
    [SerializeField] private Transform[] spawnPoints;

    [SerializeField] private float spawnTime = 1.0f;
    [SerializeField] private float repeatRate = 4.0f;

    //[Range(0.5f, 5.0f] 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void spawnObstacles()
    {
        int randomSpawn = GetRandomNumber(spawnPoints.Length);

        GameObject obstacle = Instantiate(itemsToSpawn[GetRandomNumber(itemsToSpawn.Length)],
           spawnPoints[randomSpawn].position, spawnPoints[randomSpawn].rotation);

        obstacle.transform.Translate(transform.forward);
    }

    private int GetRandomNumber(int maxLength)
    {
        return Random.Range(0, maxLength);
    }
}
