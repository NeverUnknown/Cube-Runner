using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        /*if (movement.rigidbody.position.y <= 0f)
        {
            movement.enabled = false;
            movement.rigidbody.position = movement.startPos;
            movement.enabled = true;
        }*/

        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.rigidbody.freezeRotation = false;
            movement.enabled = false; //GetComponent<PlayerMovement>().enabled = false;
            //movement.rigidbody.position = movement.startPos;
            //movement.enabled = true;
            FindObjectOfType<GameManager>().EndGame();

        }

    }
}
