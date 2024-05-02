using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Variables
    public Transform janitor;
    public float mouseX;
    public float mouseY;
    float cameraYRotation;
    float cameraXRotation;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Mouse direction
        float x = Input.GetAxis("Mouse X") * Time.deltaTime * mouseX;
        float y = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseY;

        //Rotation of the Camera of its x axis
        cameraYRotation += x;
        //Rotation of the Player Object and the Camera of it y axis
        cameraXRotation -= y;
        cameraXRotation = Mathf.Clamp(cameraXRotation, -90f, 90f);

        //rotate
        transform.rotation = Quaternion.Euler(cameraXRotation, cameraYRotation, 0);
        janitor.rotation = Quaternion.Euler(0, cameraYRotation, 0);

    }
}
