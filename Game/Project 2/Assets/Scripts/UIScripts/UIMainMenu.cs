using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class UIMainMenu : MonoBehaviour 
{
    private float musicVolumeHolder;
    public Text musicVolume;
    public AudioMixer menuMusicMixer;

	public void NewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MenuMusic()
    {
        musicVolumeHolder = GameObject.Find("MenuMusicSlider").GetComponent<Slider>().value;
        musicVolume.text = musicVolumeHolder.ToString();
        menuMusicMixer.SetFloat("Volume", musicVolumeHolder);
    }
}
