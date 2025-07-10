using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor_Script : MonoBehaviour
{
    
    Camera Camera;
    [SerializeField] public GameObject gameobject;
    [SerializeField] public Dropdown dropdown;
    void Start()
    {
      dropdown.options.Clear();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
