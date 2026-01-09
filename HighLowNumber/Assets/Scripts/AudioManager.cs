using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [Header("AudioClip")]
    public List<AudioClip> bgmAudioClip = new List<AudioClip>();
    public AudioClip correctAnswer;
    public AudioClip wrongAnswer;
    public AudioClip WinGame;
    public AudioClip LostGame;

    [Header("AudioSource")]
    public AudioSource audioBGM;
    public AudioSource audioEffect;

    public void PlayBGMAudio()
    {
        int randomIndex = Random.Range(0, bgmAudioClip.Count-1);
        audioBGM.clip = bgmAudioClip[randomIndex];
        audioBGM.Play();
        audioBGM.loop = true;
    }

    public void PlayCorrectAnswer()
    {
        audioEffect.PlayOneShot(correctAnswer);
    }

    public void PlayWrongAnswer()
    {
        audioEffect.PlayOneShot(wrongAnswer);
    }
}
