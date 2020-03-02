using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    [SerializeField] private Text timerText;
    public float time;
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timerText.text = $"Timer: {Mathf.RoundToInt(time)}";
    }
}
