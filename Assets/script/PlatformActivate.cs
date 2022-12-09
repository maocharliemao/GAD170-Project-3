using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformActivate : MonoBehaviour
{
    // this script is for the platform
    //turns of mesh and collider
    //calls back to event buss

    // Start is called before the first frame update
    void Start()
    {
        eventBus.Current.blockGoOn += blockGoOn;
        eventBus.Current.blockGoOff += blockGoOff;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void blockGoOn() {
        gameObject.GetComponent<BoxCollider>().enabled = true;
        gameObject.GetComponent<MeshRenderer>().enabled = true;
    }

    void blockGoOff() {
        gameObject.GetComponent<BoxCollider>().enabled = false;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
    void OnDestroy()
    {
        eventBus.Current.blockGoOn -= blockGoOn;
        eventBus.Current.blockGoOff -= blockGoOff;
    }
}