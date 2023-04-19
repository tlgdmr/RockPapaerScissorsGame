using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] float speed;

    [SerializeField] private Vector2 direction;

    public Vector2 GetDirection() { return direction; }
    public void SetDirection(Vector2 newDirection) { direction = newDirection; }

    private void Start()
    {
        direction = new Vector2(UnityEngine.Random.Range(-10f, 10f), UnityEngine.Random.Range(-10f, 10f)).normalized;
    }

    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
