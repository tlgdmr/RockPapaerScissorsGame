using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField] ImageController imageController;
    [SerializeField] SceneController sceneController;

    [SerializeField] Button buttonForRock;
    [SerializeField] Button buttonForPaper;
    [SerializeField] Button buttonForScissors;


    void Start()
    {
        buttonForRock.onClick.AddListener(OnButtonForRockClick);
        buttonForPaper.onClick.AddListener(OnButtonForPaperClick);
        buttonForScissors.onClick.AddListener(OnButtonForScissorsClick);
    }

    void OnButtonForRockClick()
    {
        imageController.SetRockImage();

        StartCoroutine(sceneController.LoadGameScene());

    }

    void OnButtonForPaperClick()
    {
        imageController.SetPaperImage();

        StartCoroutine(sceneController.LoadGameScene());
    }

    void OnButtonForScissorsClick()
    {
        imageController.SetScissorsImage();

        StartCoroutine(sceneController.LoadGameScene());
    }
}
