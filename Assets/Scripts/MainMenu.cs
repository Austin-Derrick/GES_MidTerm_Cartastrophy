using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject creditsMenu;
    private void Start()
    {
        Time.timeScale = 0;
    }
    public void StartGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        mainMenu.SetActive(false);
    }
    public void ShowCredits()
    {
        creditsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }
    public void ShowMainMenu()
    {
        creditsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
    public void QuitGame()
    {

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
