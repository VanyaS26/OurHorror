using UnityEngine;

public class CloseSettingsButton : MonoBehaviour
{
    public GameObject settingsPanel;          
    public GameObject[] otherButtons;        

    public void CloseSettings()
    {
        if (settingsPanel != null)
            settingsPanel.SetActive(false);

        foreach (GameObject button in otherButtons)
        {
            if (button != null)
                button.SetActive(true);
        }
    }
}
