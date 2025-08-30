using System.Xml.Xsl;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MoodScript : MonoBehaviour
{
    [SerializeField] private float mood;
    [SerializeField] private Slider slider;
    [SerializeField] private UnityEvent UnityEvent;
    float rd;

    public void moodDamage(float damage) 
    {
        mood -= damage;
        slider.value = mood;
        PlayerPrefs.SetFloat("mood",mood);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mood = PlayerPrefs.GetFloat("mood", 100);
        slider.value = mood;
        rd = Random.Range(30,200);
    }

    // Update is called once per frame
    void Update()
    {
        rd -= Time.deltaTime;
        if (rd <= 0)
        {
            if (mood < 100 && mood > 80)
            {
                int rd2 = Random.Range(1, 101);
                if (rd2 >= 1 && rd2 < 70)
                {
                    UnityEvent.AddListener(Volume);
                }
                else if (rd2 >= 71 && rd2 < 90)
                {
                    UnityEvent.AddListener(Screamer);
                }
                else if (rd2 >= 91 && rd2 < 98)
                {
                    UnityEvent.AddListener(Galucination);
                }
                else { 
                    UnityEvent.AddListener(Monster);
                }
            }
            
            
        }

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
