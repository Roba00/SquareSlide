using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public MovementController movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("You hit an obstacle!");
            FindObjectOfType<MovementController>().enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
