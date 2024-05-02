using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    //Variables
    //Camera position
    public Transform cameraPos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Update the camera position with the current camera position
        transform.position = cameraPos.position;

    }
}
