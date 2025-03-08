using UnityEngine.Audio;
using System;
using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;

public class AudioManager : Singleton<AudioManager>
{
    public int defaultMasterVolume;

    public int defaultEffectsVolume;
    public List<Sound> sounds = new List<Sound>();


    private void Awake()
    {
        foreach (Sound sound in sounds)
        {
            sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.clip = sound.clip;

            sound.source.volume = sound.volume;
            sound.source.pitch = sound.pitch;
            sound.source.loop = sound.looping;
        }
    }

    public void PlaySound(string name)
    {
        PlaySound(name, false);
    }

    public void PlaySound(string name, bool canPlayMultiple = false)
    {
        Sound selectedSound = sounds.Find(s => s.name == name);

        if (selectedSound == null)
        {
            Debug.LogWarning("Sound: " + name + "not found.");
            return;
        }

        if (!selectedSound.source.isPlaying || canPlayMultiple)
        {
            selectedSound.source.Play();
        }
    }

    public void StopSound(string name)
    {
        Sound selectedSound = sounds.Find(s => s.name == name);

        if (selectedSound == null)
        {
            Debug.LogWarning("Sound: " + name + "not found.");
            return;
        }

        if (selectedSound.source.isPlaying)
        {
            selectedSound.source.Stop();
        }
    }

    public void SetGameVolume(float newMasterVolume, float newEffectVolume)
    {
        foreach (Sound sound in sounds)
        {
            sound.source.volume = newMasterVolume * newEffectVolume * sound.volume;

        }
    }

}
