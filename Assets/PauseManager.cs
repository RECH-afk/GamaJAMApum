using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EasyTransition;
using UnityEngine.SceneManagement;
public class PauseManager : MonoBehaviour
{
    public FirstPersonLook personLook;
    public GameObject PauseMenu;
    public DemoLoadScene loadScene;
    public TransitionSettings transition;
    public float startDelay;
    public string _sceneName;
    void Start()
    {
        PauseMenu.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            personLook.enabled = false;
            PauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void PlayPauseButton()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
        personLook.enabled = true;
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void QuitMenuPauseButton()
    {
        Cursor.lockState = CursorLockMode.None;
        LoadScene(_sceneName);
        Time.timeScale = 1;
    }
    public void QuitGamePauseButton()
    {
        Cursor.lockState = CursorLockMode.None;
        Application.Quit();
    }
    public void LoadScene(string _sceneName)
    {
        TransitionManager.Instance().Transition(_sceneName, transition, startDelay);
    }
}