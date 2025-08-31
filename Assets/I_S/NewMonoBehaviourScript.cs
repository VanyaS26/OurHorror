using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] Animation animation1;
    [SerializeField] Animation animation2;
    [SerializeField] GameObject Key;
   
    public bool f1 = true;
    public bool f2 = false;
    public bool f3 = true;
    public float Timer = 3f;
    void Update()
    {
        if (f2 == true)
        {
            if (Timer > 0 && f3 == true)
            {
                Timer -= Time.deltaTime;
                if (Timer <= 0)
                {
                    f3 = false;
                    Key.SetActive(false);
                   
                }
            }

        }

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && f1 == true)
        {
            Key.SetActive(true);
            animation1.Play();
            animation2.Play();


            f1 = false;
            f2 = true;

        }
    }
}
