using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    private float timeBetweenSpawn = 1.5f;
    private float nextspawnTime;
    public GameObject[] enemy;
    public Transform[] spawnPoints;
    public AudioSource source;
    public AudioClip enemyscreech;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextspawnTime)
        {
            nextspawnTime = Time.time + timeBetweenSpawn;
            Transform randomSpawnPoint = spawnPoints[Random.Range(0,spawnPoints.Length)];
            GameObject randomEnemy = enemy[Random.Range(0, enemy.Length)];
            Instantiate(randomEnemy,randomSpawnPoint.position,Quaternion.identity);
            source.clip = enemyscreech;
            source.Play();

        }
    }
}
