using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    public static bool isPaused;
    public bool isCursorLocked = false;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            if(isPaused)
            {
                resumeGame();
            }
            else
            {
                pauseGame();
            }

            
Cursor.lockState = isCursorLocked ? CursorLockMode.Locked : CursorLockMode.None;
Cursor.visible = !isCursorLocked;
        }
        
    }

    public void pauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void resumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void backToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
