using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public GameObject settingsPanel;          
    public GameObject[] otherButtons;         

    public void OpenSettings()
    {
        if (settingsPanel != null)
            settingsPanel.SetActive(true);

        foreach (GameObject button in otherButtons)
        {
            if (button != null)
                button.SetActive(false);
        }
    }
}
