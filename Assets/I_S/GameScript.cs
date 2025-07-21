using UnityEngine;

public class GameScript : MonoBehaviour
{
    
    [SerializeField] GameObject StartButton;
    [SerializeField] GameObject  Button1;
    [SerializeField] GameObject  Button2;
    [SerializeField] GameObject  Button3;
    [SerializeField] GameObject  Button4;
    [SerializeField] GameObject  Button5; 
    [SerializeField] GameObject  Button6;
    [SerializeField] GameObject Button7;
    [SerializeField] GameObject Button8;
    [SerializeField] GameObject Button9;
    public bool f1=false;
    public bool f2=false;
    public int a = 0;
    public int count=0;
    public float timer = 0f;
    [SerializeField] GameObject panel;

    private int Random1()
    {
        return Random.Range(1, 11);  
    }

    public  void OnTriggerEnter(Collider other )
    {
        f1=true;
    }
    private void Start()
    {
        int a = Random1();
        

    }
    void Update()
    {
        
       if (f1 == true)
       {
            StartButton.SetActive(true);
       } 
    }
    public void GameStart()
    {
        Game();
    }
    public void Game()
    {
        Button1.SetActive(false);
        Button2.SetActive(false);
        Button3.SetActive(false);
        Button4.SetActive(false);
        Button5.SetActive(false);
        Button6.SetActive(false);
        Button7.SetActive(false);
        Button8.SetActive(false);
        Button9.SetActive(false);
        if (count<=15)
        {
            if (a == 1)
            {
                Button1.SetActive(true);
                int a = Random1();
                count += 1;
            }
            if (a == 2)
            {
                Button2.SetActive(true);
                int a = Random1();
                count += 1;
            }
            if (a == 3)
            {
                Button3.SetActive(true);
                int a = Random1();
                count += 1;
            }
            if (a == 4)
            {
                Button4.SetActive(true);
                int a = Random1();
                count += 1;
            }
            if (a == 5)
            {
                Button5.SetActive(true);
                int a = Random1();
                count += 1;
            }
            if (a == 6)
            {
                Button6.SetActive(true);
                int a = Random1();
                count += 1;
            }
            if (a == 7)
            {
                Button7.SetActive(true);
                int a = Random1();
                count += 1;
            }
            if (a == 8)
            {
                Button8.SetActive(true);
                int a = Random1();
                count += 1;
            }
            if (a == 9)
            {
                Button9.SetActive(true);
                int a = Random1();
                count += 1;
            }
        }
        else
        {
            panel.SetActive(true);
        }

    }
}
