using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhysicsMover : MonoBehaviour
{
    public float movementSpeed;
    public float jumpPower;
    public float mouseSpeed;
    Rigidbody rigi;
    Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //sets the Z value to the players Vertical input
        movement.z = Input.GetAxis("Vertical");
        //sets the X value to the players Horizontal input
        movement.x = Input.GetAxis("Horizontal");
        //Multiplies movement by movement speed
        movement *= movementSpeed;

        //IF we press the space bar...
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //set the Y value to equal our jump power
            movement.y = jumpPower;
        }
        else if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            movement.y = -jumpPower*5;
        }
        else //if we HAVEN'T pressed the space bar
        {
            //Let the rigidbody system take control of the Y axis. (eg. leave it alone)
            movement.y = rigi.velocity.y;
        }


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //quit the game
            Application.Quit();
            Debug.Log("Quit");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            //restart the game
            SceneManager.LoadScene(0);
        }


        //apply movement speed
        rigi.velocity = transform.TransformDirection(movement);


        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * mouseSpeed);

    }
}
