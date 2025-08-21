using UnityEngine;

public class SettingsController : MonoBehaviour
{
    public GameObject settingsPanel;       
    public GameObject closeButton;         
    public GameObject[] otherButtons;     

   
    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
        closeButton.SetActive(true);

        foreach (GameObject button in otherButtons)
        {
            button.SetActive(false);
        }
    }

    
    public void CloseSettings()
    {
        settingsPanel.SetActive(false);
        closeButton.SetActive(false);

        foreach (GameObject button in otherButtons)
        {
            button.SetActive(true);
        }
    }
}
