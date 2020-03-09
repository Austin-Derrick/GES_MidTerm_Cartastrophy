using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    Rigidbody bulletRb;
    [SerializeField] GameObject firePosition;
    bool canFire = true;
    int firePower = 150;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (canFire && Input.GetMouseButtonDown(0))
        {
            shootBullet();
        }
    }

    private void shootBullet()
    {
        bulletPrefab = Instantiate(bulletPrefab, firePosition.transform.position, Quaternion.Euler(bulletPrefab.transform.rotation.x, 0, 0));
        bulletRb = bulletPrefab.GetComponent<Rigidbody>();
        //float angle = -2.5f * Mathf.Deg2Rad;
        //Vector3 shootDirection = Vector3.RotateTowards(transform.forward, Vector3.up, angle, 0);
        bulletRb.AddForce(Vector3.forward * firePower, ForceMode.Impulse);
        canFire = false;
        Invoke("fireBuffer", 1 / 5);
    }

    private void fireBuffer()
    {
        canFire = true;
    }
}
