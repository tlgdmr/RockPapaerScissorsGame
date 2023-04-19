using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PaperCollisionDetection : MonoBehaviour
{
    GameObject background;

    [SerializeField] GameObject scissors;

    private void Start()
    {
        background = GameObject.FindWithTag("Background");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Scissors")
        {
            Destroy(gameObject);
            Instantiate(scissors, new Vector3(collision.contacts[0].point.x, collision.contacts[0].point.y, 0), Quaternion.identity, background.transform);
        }
    }
}
