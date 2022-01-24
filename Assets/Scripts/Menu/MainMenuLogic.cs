using UnityEngine;

public class MainMenuLogic : MonoBehaviour
{
    public LevelDataCaretaker levelLsit;
    public GameObject panel;
    public GameObject button;

    public void Quit()
    {
        Application.Quit();
    }

    public void RefteshLevelList()
    {
        foreach (Transform child in panel.transform)
        {
            Destroy(child.gameObject);
        }

        foreach (LevelData level in levelLsit.originator)
        {
            if (level.unlocked)
            {
                var playbutton = Instantiate(button, panel.transform);
                var levelPanel = playbutton.GetComponent("LevelPanelLogic") as LevelPanelLogic;
                levelPanel.Setup(level);
            }
        }
    }
}
