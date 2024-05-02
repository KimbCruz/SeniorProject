using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrashCollect : MonoBehaviour
{

    public GameObject VacuumCleaner;
    
    

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

        if (VacuumCleaner.GetComponent<VacuumCollector>().vacuumCollected)
        {

            //Move the trash out of the Player's view
            transform.position = new Vector3(-42f, 38f, -1f);

            AddTrashScore();

        }
        
    }

    void AddTrashScore()
    {

        RubbishManager.rubbishCount++;

    }
}
