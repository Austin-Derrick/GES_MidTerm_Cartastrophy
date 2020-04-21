using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefillAmmo : MonoBehaviour
{
    private ShootBullet AmmoManager;
    [SerializeField] AmmoTextManager ammoTextManager;


    private void Start()
    {
        AmmoManager = GameObject.FindGameObjectWithTag("Player").GetComponent<ShootBullet>();
        ammoTextManager = GameObject.FindGameObjectWithTag("Player").GetComponent<AmmoTextManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            AmmoManager.ammo += 1;
            ammoTextManager.UpdateText();
        }
    }
}
