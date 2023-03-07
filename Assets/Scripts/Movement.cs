using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    Rigidbody rb;
    private bool goRight = false;
    private bool goLeft = false;
    private int speed; 

    public Rigidbody Rb { get => rb; set => rb = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (goLeft)
        {
            MoveLeft(speed);
        }
        if (goRight)
        {
            MoveRight(speed);
        }
    }

    public void MoveLeft(int speed)
    {
        Debug.Log("Movement called");
        rb.velocity = new Vector3(-speed,0);   
    }

    public void MoveRight(int speed)
    {
        Debug.Log("Movement called");
        rb.velocity = new Vector3(+speed,0);
    }

    public void Jump()
    {

    }
}
