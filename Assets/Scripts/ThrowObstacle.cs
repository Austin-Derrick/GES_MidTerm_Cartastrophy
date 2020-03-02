using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObstacle : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    private Rigidbody obstacleRb;
    private float throwForce = 100;
    // Start is called before the first frame update
    void Start()
    {
        obstacleRb = obstaclePrefab.GetComponent<Rigidbody>();
        InvokeRepeating("InstatiateObstacle", 0.5f, 3);
    }

    private void InstatiateObstacle()
    {
        Quaternion spawnRotation = obstaclePrefab.transform.rotation;
        Vector3 spawnPos = transform.position;
        spawnPos.y += 5.0f;
        spawnRotation.y += 90;
        Instantiate(obstaclePrefab, spawnPos, spawnRotation);
        throwObject();
    }
    private void throwObject()
    {
        obstacleRb.AddForce(Vector3.back * throwForce * Time.deltaTime, ForceMode.Impulse);
        obstacleRb.AddTorque(180 * 50 * Time.deltaTime, 0, 0, ForceMode.Impulse);
    }
}
