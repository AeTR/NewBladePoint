using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public bool rightSide;

    public Enemy[] enemiesToSpawn;

    public int[] enemySpawnTimers, enemyTypes; //0 is dog, 1 is skull, 3 is spring, 4 is demon

    private Vector3[] _spawnLocations; //dog, then skull, then spring, then demon
    
    // Start is called before the first frame update
    void Start()
    {
        var position = transform.position;
        _spawnLocations = new[] {new Vector3(position.x, -3.25f, 0f),
            new Vector3(position.x, -3f, 0f), new Vector3(position.x, -3.2f, 0f), new Vector3(position.x, 3f, 0f)};
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() //50 times a second
    {
        for (int i = 0; i < enemySpawnTimers.Length; i++)
        {
            enemySpawnTimers[i]--;
            if (enemySpawnTimers[i] == 0)
            {
                Instantiate(enemiesToSpawn[i], _spawnLocations[enemyTypes[i]], Quaternion.identity).Prepare(rightSide);
            }
        }
    }
}
