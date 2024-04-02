using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyWayPoint : MonoBehaviour
{
    public bool velocity;
    public bool desiredVelocity;
    public bool path;

    NavMeshAgent migo;

    // Start is called before the first frame update
    void Start()
    {
        migo = GetComponent<NavMeshAgent>();
    }

    private void OnDrawGizmos()
    {
        if(velocity)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(transform.position, transform.position + migo.velocity);
        }

        if(desiredVelocity)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, transform.position + migo.desiredVelocity);
        }

        if(path)
        {
            Gizmos.color = Color.black;
            var migoPath = migo.path;
            Vector3 prevCorner = transform.position;
            foreach(var corner in migoPath.corners)
            {
                Gizmos.DrawLine(prevCorner, corner);
                Gizmos.DrawSphere(corner, 01f);
                prevCorner = corner;
            }
        }
    }
}
