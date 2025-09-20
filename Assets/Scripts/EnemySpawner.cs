using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public Transform[] enemySpawnPoints;
    public float spawnDelay;
    private float currentSpawnTimer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentSpawnTimer += Time.deltaTime;

        if (currentSpawnTimer > spawnDelay)
        {
            currentSpawnTimer = 0;
            Spawn();
        }
    }

    public void Spawn()
    {
        // Arrays start at 0 and end at the total amount of objects in the array -1
        GameObject randomPrefab = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
        Transform randomTransform = enemySpawnPoints[Random.Range(0, enemySpawnPoints.Length)];

        Instantiate(randomPrefab, randomTransform.position, Quaternion.identity);
    }
}
