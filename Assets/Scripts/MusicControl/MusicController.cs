using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public static MusicController instance;

    [SerializeField] AudioSource audioSource;

    [SerializeField] AudioClip gameMusic;
    [SerializeField] AudioClip gameOverMusic;

    private void Awake()
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

        audioSource.clip = gameMusic;
        audioSource.Play();
    }
    public void SetGameMusic()
    {
        audioSource.clip = gameMusic;
        audioSource.Play();
    }

    public void SetGameOverMusic()
    {
        audioSource.clip = gameOverMusic;
        audioSource.Play();
    }
}
