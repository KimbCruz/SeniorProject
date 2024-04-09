using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Add AI that will follow the Player
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FollowPlayer : MonoBehaviour
{
    public Transform janitor;
    //Enemy
    public NavMeshAgent migo;

    public CanvasGroup canvasGroup;

   
    // Start is called before the first frame update



    void Start()
    {
        migo = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (RubbishManager.rubbishCount >= 5 &&  canvasGroup.alpha == 0)
        {
            migo.destination = janitor.position;
            
        }
            
    }

    


    

}
