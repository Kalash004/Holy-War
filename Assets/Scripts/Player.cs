using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    private Movement movement;
    private PlayerInputService inputService;


    // Start is called before the first frame update
    void Start()
    {
        movement = gameObject.AddComponent<Movement>() as Movement;
        inputService = gameObject.AddComponent <PlayerInputService>() as PlayerInputService;
        movement.Rb = rb;
        inputService.Movement = movement;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
