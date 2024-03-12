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
        //Set a custom position for the vacuum
        Vector3 customPosition = new Vector3(-7f, 38f, -43f);
        transform.position = new Vector3(-7f, 38f, -43f);

        vacuumCollected = true;

        //Hide the canvasGroup
        canvasGroup.alpha = 0;
    }
}
