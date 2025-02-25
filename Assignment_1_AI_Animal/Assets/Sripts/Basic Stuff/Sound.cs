using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Sound 
{
    public enum Type
    {
        sfx
    }

    public string name;

    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume = 1f;

    [Range(0.1f, 3f)]
    public float pitch = 1f;

    public bool looping;

    [HideInInspector]
    public AudioSource source;

    public Type type;
}

[System.Serializable]
public class SoundVariant
{

    public string name;
    public List<Sound> variants;

    public void PlayVariant()
    {
        int randomIndex = Random.Range(0, variants.Count);
        variants[randomIndex].source.Play();
    }

    public void stopAllVariants()
    {
        foreach (Sound variant in variants)
        {
            variant.source.Stop();
        }
    }
}
