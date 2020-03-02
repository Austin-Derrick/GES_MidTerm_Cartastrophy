using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObstacle : MonoBehaviour
{
    //[SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private GameObject[] obstacleArray;
    private Rigidbody obstacleRb;
    private float throwForce = 100;
    // Set a reference to the current prefab then apply force
    private GameObject currentPrefab;
    // Start is called before the first frame update
    void Start()
    {
        obstacleRb = obstacleArray[getRandomNumber()].GetComponent<Rigidbody>();
        InvokeRepeating("InstatiateObstacle", 0.5f, 3);
    }

    private void InstatiateObstacle()
    {
        int obstacleIndex = getRandomNumber();
        Quaternion spawnRotation = obstacleArray[obstacleIndex].transform.rotation;
        Vector3 spawnPos = transform.position;
        spawnPos.y += 5.0f;
        spawnRotation.y += 90;
        Instantiate(obstacleArray[obstacleIndex], spawnPos, spawnRotation);
        throwObject();
    }
    private void throwObject()
    {
        obstacleRb.AddForce(Vector3.back * throwForce * Time.deltaTime, ForceMode.Impulse);
        obstacleRb.AddTorque(180 * 50 * Time.deltaTime, 0, 0, ForceMode.Impulse);
    }

    private int getRandomNumber()
    {
        return Random.Range(0, obstacleArray.Length);
    }
}
