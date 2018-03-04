using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour
{
    public AudioSource sound;
    public static AudioManager audioInstance = null;

    // Use this for initialization
    void Awake()
    {
        if (audioInstance == null)
        {
            audioInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void Play(AudioClip clip)
    {
        sound.clip = clip;
        sound.Play();
    }
}