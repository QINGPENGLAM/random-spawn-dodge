using UnityEngine;

public class blockspawner : MonoBehaviour
{
    public Transform[] spawnpoint;

    public GameObject blockprefab;

    private float timeToSpawn = 2f;

    public float timebetweenwaves = 1f;
    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            spawnblocks();
            timeToSpawn = Time.time + timebetweenwaves;
        }
        
    }

    void spawnblocks()
    {
        int randomIndex = Random.Range(0, spawnpoint.Length);

        for (int i = 0; i < spawnpoint.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(blockprefab, spawnpoint[i].position, Quaternion.identity);
            }
        }
    }
}

    
