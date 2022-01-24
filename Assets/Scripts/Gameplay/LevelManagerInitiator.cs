using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerInitiator : MonoBehaviour
{
    readonly LevelManager menager = LevelManager.Instance;
    public List<GameObject> checkpoints = new List<GameObject>();
    public TextMeshProUGUI livesText;
    public TextMeshProUGUI scoreText;
    public GameObject player;
    public LevelDataCaretaker levelsInfo;
    readonly int score = 0;
    public int lives = 3;
    readonly int newestChekpoint = 0;
    void Start()
    {
        menager.checkpoints = checkpoints;
        menager.livesText = livesText;
        menager.scoreText = scoreText;
        menager.player = player;
        menager.levelsInfo = levelsInfo;
        menager.score = score;
        menager.lives = lives;
        menager.newestChekpoint = newestChekpoint;
        menager.levelID = SceneManager.GetActiveScene().buildIndex;
        menager.livesText.text = "" + lives;
        menager.scoreText.text = "" + score;
    }
}
