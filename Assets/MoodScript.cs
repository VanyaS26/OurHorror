using System.Xml.Xsl;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MoodScript : MonoBehaviour
{
    [SerializeField] private float mood;
    [SerializeField] private Slider slider;
    [SerializeField] private UnityEvent UnityEvent;

    public void moodDamage(float damage) 
    {
        mood -= damage;
        slider.value = mood;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mood = PlayerPrefs.GetFloat("mood", 100);
        slider.value = mood;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Volume()
    {
    
    }

    private void Screamer()
    {
        
    }

    private void Galucination()
    {

    }

    private void Monster()
    {
         
    }
}
