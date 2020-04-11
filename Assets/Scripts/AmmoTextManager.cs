using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoTextManager : MonoBehaviour
{
    [SerializeField] Text ammoText;
    ShootBullet playerAmmo;
    // Start is called before the first frame update
    void Start()
    {
        playerAmmo = GameObject.FindGameObjectWithTag("Player").GetComponent<ShootBullet>();
    }

    // Update is called once per frame
    void Update()
    {
        ammoText.text = $"Ammo: {playerAmmo.ammo}";
    }
}
