using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public sealed class LevelManager
{
    public int levelID;
    public List<GameObject> checkpoints;
    public int newestChekpoint;
    public LevelDataCaretaker levelsInfo;
    public int lives;
    public TextMeshProUGUI livesText;
    public TextMeshProUGUI scoreText;
    public GameObject player;
    public int score;

    private LevelManager() { }

    public static LevelManager Instance { get; } = new LevelManager();

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void UnlockChekpoint(GameObject tounlock)
    {
        var index = checkpoints.IndexOf(tounlock);
        if (newestChekpoint <= index)
            newestChekpoint = index;
    }
    public void RespawnPlayer()
    {
        var where = checkpoints[newestChekpoint];
        player.transform.position = where.transform.position;
    }

    public void UpdateScore(int update)
    {
        score += update;
        scoreText.text = "" + score;
    }

    public void TakeDamage()
    {
        lives--;
        livesText.text = "" + lives;
        if (lives == 0)
            Die();
        else
            RespawnPlayer();
    }
    private void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
