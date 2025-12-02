using UnityEngine;
using UnityEngine.Audio;

public class AudioSettings : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetMusic(float vol)
    {
        if (mixer != null) mixer.SetFloat("Music", Mathf.Log10(Mathf.Clamp(vol,0.0001f,1f)) * 20);
    }

    public void SetSFX(float vol)
    {
        if (mixer != null) mixer.SetFloat("SFX", Mathf.Log10(Mathf.Clamp(vol,0.0001f,1f)) * 20);
    }
}