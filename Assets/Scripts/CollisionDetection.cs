using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private int health = 3;
    LivesManager livesManager;
    public AudioClip crashSound;
    public ParticleSystem smokeParticle;
    private AudioSource crashAudio;
    // Start is called before the first frame update
    void Start()
    {
        livesManager = GetComponent<LivesManager>();
        crashAudio = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(collision.gameObject);
            smokeParticle.Play();
            crashAudio.PlayOneShot(crashSound, 1.0f);
            livesManager.UpdateText();
        }
    }
}
