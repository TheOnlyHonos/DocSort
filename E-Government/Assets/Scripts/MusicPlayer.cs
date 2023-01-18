using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource Music;

    private bool isMusicPlaying = true;

    public static MusicPlayer Instance;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (isMusicPlaying)
        {
            Music.Pause();
            isMusicPlaying = false;
        } else
        {
            Music.Play();
            isMusicPlaying = true;
        }
        
    }
}
