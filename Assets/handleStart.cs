using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class handleStart : MonoBehaviour
{
    // Start is called before the first frame update
    public void startLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
    }

    public void RetardLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
}
