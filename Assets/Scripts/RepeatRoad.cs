using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatRoad : MonoBehaviour
{
    [SerializeField] GameObject player;
    Collider collider;

    private void Start()
    {
        collider = GetComponent<Collider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("Player"))
        {
            transform.position += new Vector3(0, 0, 150);
        }
    }

    private void Update()
    {
        if (player.transform.position.z >=  collider.bounds.min.z)
        {
            transform.position += new Vector3(0, 0, 150);
        }
    }
}
