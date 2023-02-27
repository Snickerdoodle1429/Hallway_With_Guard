using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMenu : MonoBehaviour
{
    public void BackToMenuWin ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -3);
    }

    public void BackToMenuLose ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
    }

    public void TryAgain ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }

}