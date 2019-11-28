﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour { 
    public playerMovement movement;

    private void OnCollisionEnter(Collision collisionInfo)
    {
    if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        } 
    }
}
