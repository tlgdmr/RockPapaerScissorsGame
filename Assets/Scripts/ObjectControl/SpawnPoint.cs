using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] GameObject background;

    [SerializeField] GameObject paper;
    [SerializeField] GameObject rock;
    [SerializeField] GameObject scissors;

    [SerializeField] GameObject paperSpawnPoint;
    [SerializeField] GameObject rockSpawnPoint;
    [SerializeField] GameObject scissorsSpawnPoint;

    int count;

    [SerializeField] int maxObjects;

    private void Start()
    {     
        count = 0;
        SpawnObjects();
    }

    private void SpawnObjects()
    {
        while (count < maxObjects)
        {
            Instantiate(paper, paperSpawnPoint.transform.position, Quaternion.identity, background.transform);

            Instantiate(rock, rockSpawnPoint.transform.position, Quaternion.identity, background.transform);

            Instantiate(scissors, scissorsSpawnPoint.transform.position, Quaternion.identity, background.transform);

            count++;
        }
    }
}
