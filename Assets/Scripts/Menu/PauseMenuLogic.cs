using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuLogic : MonoBehaviour
{
    public GameObject pauseMenuPanel;

    public void PauseGame()
    {
        pauseMenuPanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void UnPauseGame()
    {
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void ReturnToMenu()
    {
        UnPauseGame();
        SceneManager.LoadScene(0);
    }
    private void Update()
    {
        if (pauseMenuPanel.activeSelf && Input.GetKeyDown(KeyCode.Escape))
            UnPauseGame();
        else if (!pauseMenuPanel.activeSelf && Input.GetKeyDown(KeyCode.Escape))
            PauseGame();
    }
}
