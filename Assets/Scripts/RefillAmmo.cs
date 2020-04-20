using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefillAmmo : MonoBehaviour
{
    private ShootBullet AmmoManager;


    private void Start()
    {
        AmmoManager = GameObject.FindGameObjectWithTag("Player").GetComponent<ShootBullet>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            AmmoManager.ammo += 3;
        }
    }
}
