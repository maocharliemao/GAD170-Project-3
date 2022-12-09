using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerforButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("h") && inRange == true)
        {
            button.ButtonTrigger();
        }



    }


    public ButtonCollider button;
    public PlatformButton button2;

    public bool inRange = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "player")
        {
            inRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "player")
        {
            inRange = false;
        }
    }

}
