using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    //Animation of the Doors
    public Animator animator;

    public Transform janitor;

    public Transform doors;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Calculate the distance from the player to the SciFi doors
        float nearDistance = Vector3.Distance(janitor.position, doors.position);

        //if the distance is near the doors start animation and open doors
        if(nearDistance <= 20 && RubbishManager.rubbishCount >= 5)
        {

            animator.SetBool("Near", true);

        }

        else
        {

            animator.SetBool("Near", false);

        }
    }
}
