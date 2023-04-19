using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class LiveObjectsController : MonoBehaviour
{
    [SerializeField] GameObject background;

    [SerializeField] TMP_Text rock;
    [SerializeField] TMP_Text scissors;
    [SerializeField] TMP_Text paper;

    int numberOfRock;
    int numberOfScissors;
    int numberOfPaper;

    private void Update()
    {
        CheckObject();
    }

    public void CheckObject()
    {
        numberOfRock = 0;
        numberOfScissors = 0;
        numberOfPaper = 0;

        for (int i = 0; i <= background.transform.childCount - 1; i++)
        {
            GameObject child = background.transform.GetChild(i).gameObject;

            if (child.CompareTag("Rock"))
            {
                numberOfRock++;
                rock.text = numberOfRock.ToString();
            }
            else if (child.CompareTag("Paper"))
            {
                numberOfPaper++;
                paper.text = numberOfPaper.ToString();
            }
            else
            {
                numberOfScissors++;
                scissors.text = numberOfScissors.ToString();
            }
        }
    }
}
