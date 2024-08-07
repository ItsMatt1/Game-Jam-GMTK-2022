﻿using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public bool loop;

    public string Name;

    public AudioClip clip;

    [Range(0f, 1f)]
    public float Volume;

    [Range(0.1f, 3f)]
    public float Pitch;

    [HideInInspector]
    public AudioSource source;
}