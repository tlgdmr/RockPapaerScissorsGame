using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageController : MonoBehaviour
{
    public static ImageController instance;

    [SerializeField] public Image choosenImage;

    [SerializeField] Image startScene;

    [SerializeField] Sprite rockImage;
    [SerializeField] Sprite paperImage;
    [SerializeField] Sprite scissorsImage;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        choosenImage.sprite = null;
    }

    public void SetRockImage()
    {
        startScene.gameObject.SetActive(true);
        choosenImage.sprite = rockImage;
    }
    public void SetPaperImage()
    {
        startScene.gameObject.SetActive(true);
        choosenImage.sprite = paperImage;
    }
    public void SetScissorsImage()
    {
        startScene.gameObject.SetActive(true);
        choosenImage.sprite = scissorsImage;
    }
    public void DestroyInstance()
    {
        if (instance == this)
        {
            instance = null;
        }

        Destroy(gameObject);
    }
}
