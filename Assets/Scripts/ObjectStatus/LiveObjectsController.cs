using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class LiveObjectsController : MonoBehaviour
{
    [SerializeField] GameEngine gameEngine;

    [SerializeField] GameObject background;

    [SerializeField] TMP_Text rock;
    [SerializeField] TMP_Text scissors;
    [SerializeField] TMP_Text paper;

    public int numberOfRock { get; private set; }
    public int numberOfScissors { get; private set; }
    public int numberOfPaper { get; private set; }

    private void Update()
    {
        CheckObject();
    }

    public void CheckObject()
    {
        numberOfRock = 0;
        numberOfScissors = 0;
        numberOfPaper = 0;

        for (int i = 0; i < background.transform.childCount; i++)
        {
            GameObject child = background.transform.GetChild(i).gameObject;

            if (child.CompareTag("Rock"))
            {
                numberOfRock++;
            }
            else if (child.CompareTag("Paper"))
            {
                numberOfPaper++;
            }
            else if (child.CompareTag("Scissors"))
            {
                numberOfScissors++;
            }

            rock.text = numberOfRock.ToString();
            paper.text = numberOfPaper.ToString();
            scissors.text = numberOfScissors.ToString();
        }
        if (background.transform.childCount > 3) { return; }

        gameEngine.CheckWinner();
    }
}

