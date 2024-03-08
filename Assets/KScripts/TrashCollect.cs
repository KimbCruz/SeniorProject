using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            Destroy(this.gameObject);
        }
        else
        {
            Debug.Log("Collect the vacuum first!");
        }
    }
}
