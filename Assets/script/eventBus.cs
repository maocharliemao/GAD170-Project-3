using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class eventBus : MonoBehaviour
{
    //public event Action eventBus
    private static eventBus _current;


    public static eventBus Current { get { return _current; } }

    private int Lives = 3; 


    private void Awake()
    {
        if (_current != null && _current != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _current = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public int ReturnLives()
    {
        return Lives;
    }

    public void RemoveLife()
    {
        Lives--;
    }

 
    // allows the platform to be turned on and off through the other script
    public event Action blockGoOff;
    public event Action blockGoOn;

    public void BlockOn()
    {
        blockGoOn();
    }

    public void BlockOff()
    {
        blockGoOff();
    }


}