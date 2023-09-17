using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float z; //rotation
    public float x;
    public float y;
    public float diameter = 0.2f;
    public float rotateSpeed = 90.0f; // Speed of rotation
    public float moveSpeed = 90.0f;

    void Update()
    {
        // Create a new rotation
        //Quaternion newRotation = Quaternion.Euler(0, 0, z);

        // Apply the new rotation to the object.
        //transform.rotation = newRotation;

        // Check for keyboard input to rotate the object
        bool rotateClockwise = Input.GetKey(KeyCode.R);
        bool rotateCounterClockwise = Input.GetKey(KeyCode.F);

        // Update rotation based on keyboard input
        if (rotateClockwise)
        {
            transform.Rotate(Vector3.forward, rotateSpeed * Time.deltaTime);
        }
        else if (rotateCounterClockwise)
        {
            transform.Rotate(Vector3.forward, -rotateSpeed * Time.deltaTime);
        }

        // Set the position of the object based on x and y values.
        transform.position = new Vector3(x, y);

        // Set the scale of the object to create a square.
        transform.localScale = new Vector3(diameter, diameter);




    }
    }



/* This code is a Unity script written in C# that is designed to manipulate the properties of a GameObject based on keyboard input. Let's break it down step by step:

Public Variables:

public float x; and public float y;: These are public float variables representing the x and y coordinates of the GameObject's position.
public float diameter = 0.2f;: This is a public float variable representing the diameter of the square shape. It has a default value of 0.2 units.
public float rotateSpeed = 90.0f;: This is a public float variable representing the speed of rotation in degrees per second. The default value is set to 90 degrees per second.
Update Method:

The Update method is a Unity event function that is called once per frame.
Rotation Input Handling:

bool rotateClockwise = Input.GetKey(KeyCode.R);: This line checks if the "R" key is currently being held down. If it is, rotateClockwise becomes true.
bool rotateCounterClockwise = Input.GetKey(KeyCode.F);: This line checks if the "F" key is currently being held down. If it is, rotateCounterClockwise becomes true.
Rotation Update:

The code inside the if and else if blocks is responsible for updating the rotation of the GameObject based on keyboard input.
If rotateClockwise is true, it means the "R" key is pressed, and the object should rotate clockwise. In this case, transform.Rotate is used to apply a rotation to the GameObject.
Vector3.forward specifies the axis of rotation, which is the Z-axis. This means the object will rotate around its Z-axis.
rotateSpeed * Time.deltaTime determines the amount of rotation applied per second. rotateSpeed is the specified rotation speed, and Time.deltaTime ensures that the rotation is frame rate independent.
If rotateCounterClockwise is true, it means the "F" key is pressed, and the object should rotate counterclockwise. The same transform.Rotate function is used, but with a negative value for rotateSpeed * Time.deltaTime, resulting in counterclockwise rotation.
Position and Scale Update:

After handling rotation, the code sets the position of the object based on the x and y values and sets the scale of the object to create a square by setting both the x and y scales to diameter.
In summary, this script listens for the "R" and "F" keys to be pressed and held down and rotates the object clockwise or counterclockwise based on the key pressed. It also sets the position and scale of the object based on the provided variables.*/