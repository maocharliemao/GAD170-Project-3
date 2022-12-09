using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInteraction : MonoBehaviour
{
    // only used this script to display lifes on game scene
    [SerializeField] TextMeshProUGUI textLives;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textLives.text = " Lifes: " + eventBus.Current.ReturnLives(); // makes life appear in corner

        if (Input.GetKeyDown("r"))
        {
            print(eventBus.Current.ReturnLives());
        }

        if (Input.GetKeyDown("q"))
        {
            eventBus.Current.RemoveLife();
        }


    }  
}
