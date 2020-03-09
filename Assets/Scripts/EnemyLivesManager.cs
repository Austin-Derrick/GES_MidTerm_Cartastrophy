using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLivesManager : MonoBehaviour
{
    public int enemyLives;
    // Start is called before the first frame update
    void Start()
    {
        
    }
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
