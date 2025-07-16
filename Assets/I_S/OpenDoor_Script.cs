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
    public bool f1 = true;
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && f1==true)
        {
            card.SetActive(true);  
            animation1.Play();
            animation2.Play();
            g_o.GetComponent<MeshRenderer>().material = material1;   
            
            f1 =false;   
        }
    }
    
  
}
