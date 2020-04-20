using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDetection : MonoBehaviour
{
    [SerializeField] EnemyLivesManager enemyLivesManager;

    private void Start()
    {
        enemyLivesManager = GameObject.Find("Enemy").GetComponent<EnemyLivesManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            enemyLivesManager.decrementLives();
            Destroy(gameObject);
        }
    }
}
