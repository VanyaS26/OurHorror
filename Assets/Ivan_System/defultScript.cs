using UnityEngine;

using UnityEngine.UI;

public class defultScript : MonoBehaviour
{
    public Slider Slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        Slider.value = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
