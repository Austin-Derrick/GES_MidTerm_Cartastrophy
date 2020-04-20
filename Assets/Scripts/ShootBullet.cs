using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    GameObject bulletClone;
    Rigidbody bulletRb;
    [SerializeField] GameObject firePosition;
    bool canFire = true;
    int firePower = 150;
    public int ammo = 5;

    // Update is called once per frame
    void Update()
    {
        if (canFire && Input.GetMouseButtonDown(0) && ammo > 0)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        bulletClone = Instantiate(bulletPrefab, firePosition.transform.position, Quaternion.Euler(bulletPrefab.transform.rotation.x, 0, 0));
        bulletRb = bulletClone.GetComponent<Rigidbody>();
        float angle = -2.5f * Mathf.Deg2Rad;
        Vector3 shootDirection = Vector3.RotateTowards(transform.forward, firePosition.transform.forward, angle, 0);
        bulletRb.AddForce(firePosition.transform.forward * firePower, ForceMode.Impulse);
        canFire = false;
        Invoke("fireBuffer", 1 / 5);
        ammo--;
    }

    private void fireBuffer()
    {
        canFire = true;
    }
}
