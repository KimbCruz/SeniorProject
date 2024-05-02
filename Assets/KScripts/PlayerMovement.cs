using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    [Header("References")]
    public Rigidbody rb;
    public Transform head;
    public Camera camera;



    [Header("Configurations")]
    public float walkSpeed;
    public float runSpeed;
    public float jumpSpeed;



    [Header("Runtime")]
    Vector3 newVelocity;
    bool isGrounded = false;
    bool isJumping = false;



    // Start is called before the first frame update
    void Start()
    {

        //  Hide and lock the mouse cursor
        Cursor.visible = true;

        //Cursor.lockState = CursorLockMode.Locked;
    }




    // Update is called once per frame
    void Update()
    {
        // Horizontal rotation
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * 2f);   
        newVelocity = Vector3.up * rb.velocity.y;

        //After collecting all trash change speed for player 
        if (RubbishManager.rubbishCount >= 5)
        {

            runSpeed = 100;

            jumpSpeed = 6;

        }

        //Based on which key the player is currently holding
        float speed = Input.GetKey(KeyCode.LeftShift) ? runSpeed : walkSpeed;

        newVelocity.x = Input.GetAxis("Horizontal") * speed;

        newVelocity.z = Input.GetAxis("Vertical") * speed;

        if (isGrounded)
        {

            if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
            {

                newVelocity.y = jumpSpeed;
                isJumping = true;

            }
        }

        rb.velocity = transform.TransformDirection(newVelocity);

    }

    void FixedUpdate()
    {
        //  Shoot a ray of 1 unit towards the ground
        if (Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit, 1f))
        {

            isGrounded = true;

        }

        else isGrounded = false;

    }

    void LateUpdate()
    {

        // Vertical rotation
        Vector3 e = head.eulerAngles;

        //The rotate speed
        e.x -= Input.GetAxis("Mouse Y") * 2f;  
        
        //Degrees
        e.x = RestrictAngle(e.x, -85f, 85f); 
        
        head.eulerAngles = e;

    }



    void OnCollisionStay(Collision col)
    {

        if (Vector3.Dot(col.GetContact(0).normal, Vector3.up) <= .6f)
        {

            return;

        }
           

        isGrounded = true;

        isJumping = false;

    }


    void OnCollisionExit(Collision col)
    {

        isGrounded = false;

    }




    //  A helper function
    //  Clamp the vertical head rotation (prevent bending backwards)
    public static float RestrictAngle(float angle, float angleMin, float angleMax)
    {

        if (angle > 180)
        {

            angle -= 360;

        }

        else if (angle < -180)
        {

            angle += 360;

        }

        if (angle > angleMax)
        {

            angle = angleMax;

        }
        if (angle < angleMin)
        {

            angle = angleMin;

        }

        return angle;

    }

    public void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag == "enemy")
        {

            //GameOver();

        }
    }
}
