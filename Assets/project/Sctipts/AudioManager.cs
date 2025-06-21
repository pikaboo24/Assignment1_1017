using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header ( "------- Audio Source -------")]
    [SerializeField] private   AudioSource musicSource;
    [SerializeField] private  AudioSource SFXSource;

    [Header("------- Audio Clip -------")]
    public AudioClip boom2;
    public AudioClip background;
    public AudioClip playerDeath;
    public AudioClip astrodDeath;
    public AudioClip enemyDeath;
    public AudioClip playerShoot;
    public AudioClip enemyShoot;
    public AudioClip enemyShoot2;
    public AudioClip boom;
    private void Start()
    {
        if (musicSource != null && background != null)
             {
                 musicSource.clip = background;
                 musicSource.loop = true;
                 musicSource.Play();
             } 
    }
    public void PlaySFX(AudioClip clip)
    {
        if (SFXSource != null && clip != null)
        {
            Debug.Log("Playing SFX:" + clip.name);

            SFXSource.PlayOneShot(clip);

        }
        else
        {
            Debug.LogWarning("SFX or Clip missing");
        }


    }


}
