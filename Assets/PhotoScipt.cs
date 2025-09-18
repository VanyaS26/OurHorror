using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class PhotoScipt : MonoBehaviour
{
    [SerializeField]private Slider Slider;
    [SerializeField]private GameObject PanelColor;
    [SerializeField] private GameObject L;
    
    private bool screen;
    private float battary;

    public void ModifyBattary(ref float battaryNew)
    {
        battary += battaryNew;
    }

    public void GetScreen(ref bool scren)
    {
        scren = screen;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Slider.maxValue = 500;       
        PanelColor.SetActive(false);
        L.SetActive(false);
        battary = PlayerPrefs.GetFloat("battary", 500);
        screen = false;
        Slider.value = battary;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q) && battary > 0) 
        {
            PanelColor.SetActive(!PanelColor.activeSelf);
            L.SetActive(!L.activeSelf);
            screen = !screen;
        }
        if (screen) 
        { 
            battary -= Time.deltaTime;
            Slider.value = battary;
            if (battary <= 0)
            {
                PanelColor.SetActive(false);
                L.SetActive(false);
                screen = false;
            }
        }
    }
}
