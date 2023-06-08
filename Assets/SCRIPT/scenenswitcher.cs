using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenenswitcher : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

        public void Back()
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 9);
        }

    public void Four2Pic()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void Begin()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 12);
    }


}
