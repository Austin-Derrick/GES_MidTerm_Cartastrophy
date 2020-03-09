using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDetection : MonoBehaviour
{
    EnemyLivesManager enemyLivesManager;
    // Start is called before the first frame update
    void Start()
    {
        enemyLivesManager = GetComponent<EnemyLivesManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            enemyLivesManager.decrementLives();
        }
    }
}
