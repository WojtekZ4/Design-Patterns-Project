using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelPanelLogic : MonoBehaviour
{
    public TextMeshProUGUI levelName;
    public TextMeshProUGUI Score;
    public Button startButton;

    public void Setup(LevelData data)
    {
        levelName.text = data.name;
        Score.text = Convert.ToString(data.highScore);
        startButton.onClick.AddListener(() => Time.timeScale = 1);
        startButton.onClick.AddListener(() => SceneManager.LoadScene(data.ID));
    }
}
