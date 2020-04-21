using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    private GameObject enemyClone;
    Vector3 spawnPos;

    public void startSpawn()
    {
        Invoke("spawnEnemy", 3);
    }

    private void Update()
    {
       spawnPos = gameObject.transform.position;
    }

    void spawnEnemy()
    {
        enemyClone = Instantiate(enemyPrefab, gameObject.transform, true);
        enemyClone.transform.parent = null;
        setPosition();
    }

    void setPosition()
    {
        enemyClone.transform.position = spawnPos;
    }
}
