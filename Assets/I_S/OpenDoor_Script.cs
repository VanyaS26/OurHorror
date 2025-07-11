using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor_Script : MonoBehaviour
{


    [SerializeField] Animation animation1;
    [SerializeField] Animation animation2;
    void Update()
    {
        animation1.GetComponent<Animation>().Play();    
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") )
        {

            animation1.Play();
            animation2.Play();
        }
    }
    
  
}
