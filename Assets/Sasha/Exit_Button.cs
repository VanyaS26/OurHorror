using UnityEngine;

public class Exit_Button : MonoBehaviour
{
    public void ExitButton()
    {
        Debug.Log("exit");
        Application.Quit();
    }
}