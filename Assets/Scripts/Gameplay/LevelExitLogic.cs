using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelExitLogic : MonoBehaviour
{
    public TMPro.TextMeshProUGUI scoreText;
    readonly LevelManager menager = LevelManager.Instance;
    public Button nextLevelButton;
    public GameObject exitMenu;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            scoreText.text = menager.scoreText.text;
            var currentscore = menager.score;
            var levelList = menager.levelsInfo.originator;
            var currentLevel = levelList.GetLevelById(menager.levelID);

            if (currentscore > currentLevel.highScore)
                menager.levelsInfo.originator.SetHighScore(currentLevel.ID, currentscore);

            if (levelList.HasNext(menager.levelID))
            {
                var nextLevel = levelList.GetLevelById(menager.levelID + 1);
                nextLevelButton.gameObject.SetActive(true);
                nextLevelButton.onClick.AddListener(() => SceneManager.LoadScene(nextLevel.ID));
                nextLevelButton.onClick.AddListener(() => Time.timeScale = 1);
                menager.levelsInfo.originator.UnlockLevel(nextLevel.ID);

            }
            menager.levelsInfo.SaveGameData();
            exitMenu.SetActive(true);
            menager.PauseGame();
        }
    }
}
