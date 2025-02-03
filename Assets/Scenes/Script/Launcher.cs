using System;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    [SerializeField] public GameObject BulletPrefab;
    [SerializeField] public float spawnRateMin = 4f;
    [SerializeField] public float spawnRateMax = 8f;

    private Transform target;
    private float spawnRate;
    private float timeAfterSpawn;

    public object SpawnRateMin { get; private set; }
    public object SpawnRateMax { get; private set; }

    void Start()
    {
        timeAfterSpawn = 0f;
        spawnRate = UnityEngine.Random.Range(spawnRateMin, spawnRateMax);

        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            target = player.transform;
        }
    }

    void Update()
    {
        timeAfterSpawn += Time.deltaTime; 

        if (timeAfterSpawn >= spawnRate)  
        {
            timeAfterSpawn = 0f;

            GameObject bullet = Instantiate(BulletPrefab, transform.position, transform.rotation);

            if (target != null)
            {
                bullet.transform.LookAt(target);
            }

            spawnRate = UnityEngine.Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
