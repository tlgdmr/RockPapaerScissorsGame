using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ObjectPosition : MonoBehaviour
{
    MovementController movementController;

    int topY = 1040;
    int bottomY = 40;
    int rightX = 1910;
    int leftX = 40;

    private void Start()
    {
        movementController = GetComponent<MovementController>();
    }

    private void Update()
    {
        CheckObjectsPosition();
    }

    private void CheckObjectsPosition()
    {
        if (transform.position.y >= topY)
        {
            Vector2 direction = movementController.GetDirection();
            direction.y = -Mathf.Abs(direction.y);
            movementController.SetDirection(direction);
        }
        if (transform.position.y <= bottomY)
        {
            Vector2 direction = movementController.GetDirection();
            direction.y = Mathf.Abs(direction.y);
            movementController.SetDirection(direction);
        }
        if (transform.position.x >= rightX)
        {
            Vector2 direction = movementController.GetDirection();
            direction.x = -Mathf.Abs(direction.x);
            movementController.SetDirection(direction);
        }
        if (transform.position.x <= leftX)
        {
            Vector2 direction = movementController.GetDirection();
            direction.x = Mathf.Abs(direction.x);
            movementController.SetDirection(direction);
        }
    }
}
