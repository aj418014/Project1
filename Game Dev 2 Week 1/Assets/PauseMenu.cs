using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }
        if(GameIsPaused == true)
        {
            if(Input.GetKeyDown(KeyCode.M))
            {
                SceneManager.LoadScene(0);
            }
            if(Input.GetKeyDown(KeyCode.Q))
            {
                print("Quit");
                Application.Quit();
            }
        }
    }


    void Resume ()
    {
        GameObject.Find("Player").GetComponent<Movement>().enabled = true;
        GameObject.Find("Main Camera").GetComponent<CameraPointer>().enabled = true;
        GameObject.Find("Pistol").GetComponent<Pistol>().enabled = true;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }


    void Pause()
    {
        GameObject.Find("Player").GetComponent<Movement>().enabled = false;
        GameObject.Find("Main Camera").GetComponent<CameraPointer>().enabled = false;
        GameObject.Find("Pistol").GetComponent<Pistol>().enabled = false;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
