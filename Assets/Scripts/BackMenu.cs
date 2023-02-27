using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class BackMenu : MonoBehaviour
{
    public void BackToMenuWin ()
    {
        SceneManager.LoadScene(0);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -3);
    }

    public void BackToMenuLose ()
    {
        //SceneManager.LoadScene(0);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
    }

    public void TryAgain ()
    {
        SceneManager.LoadScene(0);
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }

}