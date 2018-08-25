using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_2D : MonoBehaviour
{

    Vector2 Playerpos;
    public int MovementDir;
    public Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Playerpos = transform.position;
        MovementDir = 0;
    }

    private void Update()
    {
        //rb.velocity = Playerpos;

        PlayerController();
        PlayerMovementController();

    }

    private void PlayerController()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            MovementDir = 1;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            MovementDir = -1;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            MovementDir = -2;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            MovementDir = 2;
        }
    }
    private void PlayerMovementController()
    {
        if (MovementDir == 1)
        {
            Playerpos.y += 0.05f;
            transform.position = Playerpos;
        }
        else if (MovementDir == -1)
        {
            Playerpos.y -= 0.05f;
            transform.position = Playerpos;
        }
        else if (MovementDir == -2)
        {
            Playerpos.x -= 0.05f;
            transform.position = Playerpos;
        }
        else if (MovementDir == 2)
        {
            Playerpos.x += 0.05f;
            transform.position = Playerpos;
        }
    }
}
