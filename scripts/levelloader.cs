using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelloader : MonoBehaviour
{
    int currentIndex;

    // Start is called before the first frame update
    void Start()
    {
        currentIndex = 0;
        currentIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }
    }

    
    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(3.1f);
        LoadNextScene();
    }

    public void LoadNextScene()

    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentIndex + 1);
    }

    public void RestartScreen()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentIndex);
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("start screen");
    }

    public void LoadOptionsScreen()
    {
        SceneManager.LoadScene("options screen");
    }

    public void LoadGameOver()
    {
        
        SceneManager.LoadScene("Game Over");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
