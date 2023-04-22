using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameEngine : MonoBehaviour
{
    [SerializeField] LiveObjectsController liveObjectsController;
    [SerializeField] MusicController musicController;
    [SerializeField] ImageController imageController;

    [SerializeField] Image winnerBackground;
    [SerializeField] Image winner;
    [SerializeField] Image choosenImage;

    [SerializeField] Sprite rockImage;
    [SerializeField] Sprite paperImage;
    [SerializeField] Sprite scissorsImage;

    private bool isGameOver;

    private void Awake()
    {
        musicController = MusicController.instance;
        imageController = ImageController.instance;
        isGameOver = false;
    }

    private void Update()
    {
        if (isGameOver) { return; }
              
        CheckWinner();
    }

    public void CheckWinner()
    {
        if (rockImage == null || paperImage == null || scissorsImage == null) { return; }

        if (liveObjectsController.numberOfPaper == 0 && liveObjectsController.numberOfRock == 0)
        {
            winnerBackground.gameObject.SetActive(true);

            winner.sprite = scissorsImage;
            choosenImage.sprite = imageController.choosenImage.sprite;

            musicController.SetGameOverMusic();

            isGameOver = true;
        }
        else if (liveObjectsController.numberOfRock == 0 && liveObjectsController.numberOfScissors == 0)
        {
            winnerBackground.gameObject.SetActive(true);

            winner.sprite = paperImage;
            choosenImage.sprite = imageController.choosenImage.sprite;

            musicController.SetGameOverMusic();

            isGameOver = true;
        }
        else if (liveObjectsController.numberOfScissors == 0 && liveObjectsController.numberOfPaper == 0)
        {
            winnerBackground.gameObject.SetActive(true);

            winner.sprite = rockImage;
            choosenImage.sprite = imageController.choosenImage.sprite;

            musicController.SetGameOverMusic();

            isGameOver = true;
        }
    }

    public void LoadMenuScene()
    {
        if (imageController != null)
        {
            imageController.DestroyInstance();
        }

        SceneManager.LoadScene("MenuScene");

        musicController.SetGameMusic();
    }

}
