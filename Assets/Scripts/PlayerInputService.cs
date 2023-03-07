using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputService : MonoBehaviour {   
    // Keybinds
    private KeyCode Left = KeyCode.A;
    private KeyCode Right = KeyCode.D;
    private KeyCode Up = KeyCode.W;

    private Movement movement; 

    public Movement Movement { get => movement; set => movement = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Left))
        {
            Debug.Log("Left");
            movement.MoveLeft(4);
        }
        if (Input.GetKeyDown(Right))
        {
            Debug.Log("Right");
            movement.MoveRight(4);
        }
        if (Input.GetKeyDown(Up))
        {

        }
        
    }
}
