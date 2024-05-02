using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VacuumCollector : MonoBehaviour
{

    //Check if vacuum is collected first
    public bool vacuumCollected = false;

    public GameObject VacuumCleaner;

    //UI Canvas telling the player to collect the vacuum
    public CanvasGroup canvasGroup;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()

    {
        //Move the vacuum out of the Player's view
        transform.position = new Vector3(-42f, 38f, -1f);

        vacuumCollected = true;

        //Hide the canvasGroup
        canvasGroup.alpha = 0;
    }
}
