using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject zombiePrefab;
    public Transform[] spawnPositions;
    public void SpawnZombies(int count)
    {
        for(int i = 0; i < count; i++)
        {
            var RandomPoint = Random.Range(0, spawnPositions.Length);
            Instantiate(zombiePrefab, spawnPositions[RandomPoint].position, transform.rotation);
        }
    }

    private void Update()
    {
        Debug.Log(Time.time);
        var zombies = GameObject.FindGameObjectsWithTag("Enemy");
        if(zombies.Length == 0)
        {
            SpawnZombies(Random.Range(25, 100));
        }
    }
}
