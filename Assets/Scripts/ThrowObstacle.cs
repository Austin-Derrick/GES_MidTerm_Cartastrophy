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
        InvokeRepeating("InstatiateObstacle", 0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InstatiateObstacle()
    {
        Quaternion spawnRotation = obstaclePrefab.transform.rotation;
        Vector3 spawnPos = transform.position;
        spawnPos.y += 5.0f;
        spawnRotation.y += 45;
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        throwObject();
    }
    private void throwObject()
    {
        obstacleRb.AddForce(Vector3.back * throwForce, ForceMode.Impulse);
    }
}
