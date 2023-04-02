using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [SerializeField] Vector2 movement;

    int randomXValue;
    int randomYValue;

    private void Start()
    {
        randomXValue = UnityEngine.Random.Range(-10, +10);
        randomYValue = UnityEngine.Random.Range(-10, +10);

        movement = new Vector2(randomXValue, randomYValue);
    }

    private void Update()
    {
        MoveObject();
    }

    private void MoveObject()
    {
        transform.Translate(movement.normalized);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall Left" || collision.gameObject.tag == "Wall Right")
        {
            randomXValue = -randomXValue;

            movement = new Vector2(randomXValue, randomYValue) * Time.deltaTime;
        }
        else if (collision.gameObject.tag == "Wall Top" || collision.gameObject.tag == "Wall Bottom")
        {
            randomYValue = -randomYValue;

            movement = new Vector2(randomXValue, randomYValue) * Time.deltaTime;
        }
    }
}
