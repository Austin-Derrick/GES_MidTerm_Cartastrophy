using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyLivesManager : MonoBehaviour
{
    private float enemyHealth;
    private float maxHealth = 5;
    [SerializeField] private Slider slider;
    private EnemySpawnManager spawnManager;

    private void Start()
    {
        enemyHealth = maxHealth;
        slider.value = CalculateHealth();
        spawnManager = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<EnemySpawnManager>();
    }

    public void decrementLives()
    {
        enemyHealth--;
        slider.value = CalculateHealth();
        checkEnemyLives();
    }
    private void checkEnemyLives()
    {
        if (enemyHealth <= 0)
        {
            spawnManager.startSpawn();
            Destroy(gameObject);
        }
    }

    private float CalculateHealth()
    {
        return enemyHealth / maxHealth;
    }
}
