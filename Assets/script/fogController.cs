using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fogController : MonoBehaviour
{
    // did not use this script idk why its here



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
        if (collider.gameObject.name == "player")
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //eventBus.Current.RemoveLife();
            collider.gameObject.GetComponent<PlayerStats>().SpikeTrap = true;

        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.name == "player")
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //eventBus.Current.RemoveLife();
            collider.gameObject.GetComponent<PlayerStats>().SpikeTrap = false;

        }
    }













}