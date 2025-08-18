using UnityEngine;

public class ChatActiveScript : MonoBehaviour
{
    public GameObject gameObject2;
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.T))
        {
            gameObject2.SetActive(!gameObject2.activeSelf);
        } 
    }



}
