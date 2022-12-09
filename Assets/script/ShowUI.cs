using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI : MonoBehaviour
{
    public GameObject PopUpText;

    void start()
    {
        PopUpText.gameObject.SetActive(false);
    }
       


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "player")
        {
            PopUpText.gameObject.SetActive(true);
        }
    }
   
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "player")
        {
            PopUpText.gameObject.SetActive(false);
        }
    }


}
