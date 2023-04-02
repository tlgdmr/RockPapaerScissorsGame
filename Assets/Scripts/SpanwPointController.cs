using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanwPointController : MonoBehaviour
{
    [SerializeField] Transform paperSpawnPoint;
    [SerializeField] Transform scissorsSpawnPoint;
    [SerializeField] Transform rockSpawnPoint;

    [SerializeField] GameObject canvas;

    [SerializeField]
    [Tooltip("The transform of the paper object.")]
    private GameObject paper;

    [SerializeField]
    [Tooltip("The transform of the rock object.")]
    private GameObject rock;

    [SerializeField]
    [Tooltip("The transform of the scissors object.")]
    private GameObject scissors;

    private void Start()
    {
        SpawnObject();
    }

    private void SpawnObject()
    {
        int count = 0;

        do
        {
            GameObject newPaper = Instantiate(paper, paperSpawnPoint.position, Quaternion.identity);
            newPaper.transform.SetParent(canvas.transform);

            //GameObject newRock = Instantiate(rock, rockSpawnPoint.position, Quaternion.identity);
            //newRock.transform.SetParent(canvas.transform);

            GameObject newScissors = Instantiate(scissors, scissorsSpawnPoint.position, Quaternion.identity);
            newScissors.transform.SetParent(canvas.transform);

            count++;

        } while (count <= 0);
    }
}
