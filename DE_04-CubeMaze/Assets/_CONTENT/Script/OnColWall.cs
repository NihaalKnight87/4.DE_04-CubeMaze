using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnColWall : MonoBehaviour {

    public static string Dead = "NotDead";

    public void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerMovement_2D.MovementDir = 0;
        Debug.Log("work");
        Dead = "PlayerDead";
    }




}
