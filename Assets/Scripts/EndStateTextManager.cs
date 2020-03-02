using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndStateTextManager : MonoBehaviour
{
    [SerializeField] Text endStateText;
    private TimerManager timerManager;
    private RestartManager restartManager;
    private void Start()
    {
        timerManager = GetComponent<TimerManager>();
        restartManager = GetComponent<RestartManager>();
    }
    public void ShowEndState()
    {
        endStateText.text = $"Game Over\nTime: {Mathf.RoundToInt( timerManager.time)}";
        showButton();
        //Time.timeScale = 0;
    }
    private void showButton()
    {
        restartManager.setButtonActive();
    }
}
