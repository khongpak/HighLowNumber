using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public List<AudioClip> bgmAudioClip = new List<AudioClip>();
    public List<AudioClip> effectAudioClip = new List<AudioClip>();
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayBGMAudio();
    }

    private void PlayBGMAudio()
    {
        int randomIndex = Random.Range(0, bgmAudioClip.Count-1);
        audioSource.clip = bgmAudioClip[randomIndex];
        audioSource.Play();
        audioSource.loop = true;
    }
}
