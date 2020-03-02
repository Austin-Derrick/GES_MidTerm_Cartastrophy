using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private int health = 3;
    LivesManager livesManager;
    // Start is called before the first frame update
    void Start()
    {
        livesManager = GetComponent<LivesManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(collision.gameObject);
            livesManager.UpdateText();
        }
    }
}
