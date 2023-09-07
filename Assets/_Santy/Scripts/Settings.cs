using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [Header("Sound")]
    public static Settings Instance;
    public SoundManager[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;

    [Header("Sensibility")]
    public Slider SliderSensibility;
    public TextMeshProUGUI SensibilityText;

    [Header("Music")]
    public Toggle MusicToggle;
    public Toggle SFXToggle;

    [Header("Sliders Color")]
    public Slider SliderRed;
    public Slider SliderGreen;
    public Slider SliderBlue;

    //[Header("Sliders Size")]
    //public Slider SliderSize;

    [Header("Crosshair")]
    public Image SpriteCrosshair;
    public Image SpriteCrosshairSettings;

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
        //SliderSize.minValue = 0.33f;
        //SliderSize.maxValue = 3f;
        SliderSensibility.value = PlayerPrefs.GetFloat("sensibilidad",0.5f);
    }


    void Update()
    {
        //Debug.Log(SliderSensibility.value);

        SliderRed.maxValue = 1;
        SliderBlue.maxValue = 1;
        SliderGreen.maxValue = 1;

        SpriteCrosshair.color = new Vector4(SliderRed.value, SliderBlue.value, SliderGreen.value, 1f);
        SpriteCrosshairSettings.color = new Vector4(SliderRed.value, SliderBlue.value, SliderGreen.value, 1f);

        //var Size = new Vector3(SliderSize.value, SliderSize.value, SliderSize.value);
        //SpriteCrosshair.rectTransform.localScale = Size;

    }


    public void MusicVolume()
    {
        if (MusicToggle.isOn == true)
        {
            musicSource.volume = 1;
        }

        if (MusicToggle.isOn == false)
        {
            musicSource.volume = 0;
        }
    }

    public void SfxVolume()
    {
        if (SFXToggle.isOn == true)
        {
            sfxSource.volume = 1;
        }

        if (SFXToggle.isOn == false)
        {
            sfxSource.volume = 0;
        }
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