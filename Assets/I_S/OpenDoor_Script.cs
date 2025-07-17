using System.Diagnostics;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor_Script : MonoBehaviour
{


    [SerializeField] Animation animation1;
    [SerializeField] Animation animation2;
    [SerializeField] GameObject g_o;
    [SerializeField] GameObject card;
    [SerializeField] Material material1;
    [SerializeField] AudioSource audio;    
    public bool f1 = true;
    public bool f2 = false ;
    public bool f3 = true;
    public float Timer = 0f;
    void Update()
    {
        if (f2==true)
        {
            if (Timer < 4 && f3==true)
            {
                Timer += 0.043f;
                if (Timer >= 4)
                {
                    f3 = false ;
                    card.SetActive(false);
                    g_o.GetComponent<MeshRenderer>().material = material1;
                    audio.Play();
                }
            }
            
        }
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && f1==true)
        {
            card.SetActive(true);  
            animation1.Play();
            animation2.Play();
  
            
            f1 =false;
            f2 =true;

        }
    }
    
  
}
