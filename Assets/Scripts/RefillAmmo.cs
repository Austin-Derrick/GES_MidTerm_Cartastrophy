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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AmmoManager.ammo += 3;
        }
    }
}
