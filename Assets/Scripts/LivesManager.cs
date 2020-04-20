using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesManager : MonoBehaviour
{
    [SerializeField] Text livesText;
    private EndStateTextManager endStateTextManager;
    private float lives = 3.5f;
    // Start is called before the first frame update
    void Start()
    {
        UpdateText();
        endStateTextManager = GetComponent<EndStateTextManager>();
    }

    private void Update()
    {
        if (lives <= 0)
        {
            endStateTextManager.ShowEndState();
        }
    }

    private void DecrementHealth()
    {
        lives -= 1f;
    }

    public void UpdateText()
    {
        DecrementHealth();
        livesText.text = $"Lives:  {lives}";
    }
}
