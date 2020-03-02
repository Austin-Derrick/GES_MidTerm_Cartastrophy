using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartManager : MonoBehaviour
{
    [SerializeField] Button restartButton;
    // Start is called before the first frame update
    void Start()
    {
        restartButton.gameObject.SetActive(false);
    }

    private void Update()
    {
        restartButton.onClick.AddListener(RestartLevel);
    }

    public void setButtonActive()
    {
        restartButton.gameObject.SetActive(true);
    }

    void RestartLevel()
    {
        SceneManager.LoadScene("Prototype 1");
        Time.timeScale = 1;
    }
    
    
}
