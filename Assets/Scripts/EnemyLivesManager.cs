using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLivesManager : MonoBehaviour
{
    private int enemyLives = 3;

    public void decrementLives()
    {
        enemyLives--;
    }
    private void checkEnemyLives()
    {
        if (enemyLives <= 0)
        {
            Destroy(gameObject);
        }
    }
}
