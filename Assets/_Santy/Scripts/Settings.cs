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
    [SerializeField] private Slider SFXSlider;

    [Header("Brightness")]  
    public Slider brightneSlider;
    private float _sliderValue = .99f;
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
        brightneSlider.value = PlayerPrefs.GetFloat("Brightness", 0.99f);
        brightnessPanel.color = new Color(brightnessPanel.color.r, brightnessPanel.color.g, brightnessPanel.color.b,
            .99f - brightneSlider.value);
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetMusicVolume();
            SetSFXVolume();
        }
    }

    public void ChangeBrightness(float value)
    {
        _sliderValue = value;
        PlayerPrefs.SetFloat("Brightness",_sliderValue);
        brightnessPanel.color = new Color(brightnessPanel.color.r, brightnessPanel.color.g, brightnessPanel.color.b,
            .99f - brightneSlider.value);
    }

    public void SetMusicVolume()
    {
        float volume = musicSlider.value;
        audioController.SetFloat("Music", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("musicVolume",volume);
    }
    public void SetSFXVolume()
    {
        float volume = SFXSlider.value;
        audioController.SetFloat("SFX", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("SFXVolume",volume);
    }

    private void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        SFXSlider.value = PlayerPrefs.GetFloat("SFXVolume");
        SetMusicVolume();
        SetSFXVolume();
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