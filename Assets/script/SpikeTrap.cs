using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeTrap : MonoBehaviour
{
    //used this script to reset player on spike trap


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.name == "player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            eventBus.Current.RemoveLife();

        }
    }




}
