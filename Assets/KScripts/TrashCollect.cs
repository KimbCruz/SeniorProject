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

            //Set a custom position for the trash
            transform.position = new Vector3(-9f, 38f, -43f);
            AddTrashScore();
        }
        
    }

    void AddTrashScore()
    {
        RubbishManager.rubbishCount++;
    }
}
