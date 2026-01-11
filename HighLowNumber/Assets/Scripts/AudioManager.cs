using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [Header("AudioClip")]
    public List<AudioClip> bgmAudioClip = new List<AudioClip>();
    public AudioClip correctAnswer;
    public AudioClip wrongAnswer;
    public AudioClip winGame;
    public AudioClip lostGame;

    [Header("AudioSource")]
    public AudioSource audioBGM;
    public AudioSource audioEffect;

    private void Start()
    {
        audioBGM.volume = 0.3f;
        audioEffect.volume = 0.3f;
    }

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

    public void PlayWinGame()
    {
        audioEffect.volume = 1.0f;
        audioBGM.Stop();
        audioEffect.PlayOneShot(winGame);
    }

    public void PlayLostGame()
    {
        audioEffect.volume = 1.0f;
        audioBGM.Stop();
        audioEffect.PlayOneShot(lostGame);
    }
}
