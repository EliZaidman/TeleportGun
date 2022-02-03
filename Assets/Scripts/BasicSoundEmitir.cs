using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BasicSoundEmitir : MonoBehaviour
{
    AudioSource audioSource;

    public void PlayMe()
    {
        audioSource.Play();
    }
}
