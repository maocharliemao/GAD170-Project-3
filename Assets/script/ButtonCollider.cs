using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // used this script to destroy the wall in the path

    public GameObject Door;

    public  void ButtonTrigger()
    {


        Destroy(Door);
        
    }
}
