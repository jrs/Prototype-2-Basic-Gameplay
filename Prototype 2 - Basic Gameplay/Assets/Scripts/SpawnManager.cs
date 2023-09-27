using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] AnimalPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 1.5f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        int index = Random.Range(0, AnimalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-10, 10), 0f, 20f);
        Instantiate(AnimalPrefabs[index], spawnPos, AnimalPrefabs[index].transform.rotation);
    }
}
