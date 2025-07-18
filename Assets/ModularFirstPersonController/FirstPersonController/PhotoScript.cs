using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class PhotoScript : MonoBehaviour
{
    public GameObject _GameObject;
    public float _recharge = 0;
    public bool _enebled = false;
    public float _time = 15;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       _GameObject.SetActive(false); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Q) && _recharge == 0)
        {
            _recharge = 450;
            _GameObject.SetActive(true);
            _enebled = true;
        }
        if (_enebled == true) 
        {
            
            _time -= 1;
            if (_time <= 0)
            {
                _GameObject.SetActive(false);
                _enebled  = false;
                _time = 15;
                _recharge = 450;
            }
        }
        if(_recharge != 0)
        {
            _recharge -= 1;
        }
    }
}
