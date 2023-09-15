using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [Header("Sound")]
    public static Settings Instance;
    public SoundManager[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;
    
    [Header("Volume")] 
    [SerializeField] private AudioMixer audioController;
    [SerializeField] private Slider musicSlider;

    [Header("Brightness")]  
    public Slider brightneSlider;
    private float _sliderValue;
    public Image brightnessPanel;

     private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    void Start()
    {
        brightneSlider.value = PlayerPrefs.GetFloat("Brightness", 0.5f);
        brightnessPanel.color = new Color(brightnessPanel.color.r, brightnessPanel.color.g, brightnessPanel.color.b,
            brightneSlider.value);
    }

    public void ChangeBrightness(float value)
    {
        _sliderValue = value;
        PlayerPrefs.SetFloat("Brightness",_sliderValue);
        brightnessPanel.color = new Color(brightnessPanel.color.r, brightnessPanel.color.g, brightnessPanel.color.b,
            brightneSlider.value);
    }

    public void SetMusicVolume()
    {
        float volume = musicSlider.value;
        audioController.SetFloat("Music", volume);
    }

    public void PlayMusic(string name)
    {
        SoundManager s = Array.Find(musicSounds, x => x.Name == name);

        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }
        else
        {
            musicSource.clip = s.Clip;
            musicSource.Play();
        }
    }

    public void PlaySfx(string name)
    {
        SoundManager s = Array.Find(sfxSounds, x => x.Name == name);

        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }
        else
        {
            sfxSource.PlayOneShot(s.Clip);
        }
    }

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void RestartScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}