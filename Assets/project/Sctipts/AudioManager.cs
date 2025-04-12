using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header ( "------- Audio Source -------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

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
        musicSource.clip = background;
        musicSource.Play();
    }
    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip); 
    }





}
