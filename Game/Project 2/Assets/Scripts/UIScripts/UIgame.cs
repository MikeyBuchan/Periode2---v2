using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIgame : MonoBehaviour 
{
    public GameObject pausemenu;
    public GameObject settings;
    public GameObject changeCard;
    public GameObject player;
    private float sensitivityHolder;
    private float brightnessHolder;
    private float FOVHolder;
    public Text sensitivity;
    public Text brightness;
    public Text FOV;


    void Update ()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            pausemenu.SetActive(true);
            GameObject.FindWithTag("Player").GetComponent<CameraMovement>().enabled = false;
            GameObject.FindWithTag("Player").GetComponent<PlayerMovement>().enabled = false;
            Time.timeScale = 0;
        }

        if (Input.GetButtonDown("1"))
        {
            ChangeToDamageCard();
        }

        if (Input.GetButtonDown("2"))
        {
            ChangeToBuildCard(); 
        }

        if (Input.GetButtonDown("3"))
        {
            ChangeToLightCard();
        }
    }

    public void Resume ()
    {
        pausemenu.SetActive(false);
        GameObject.FindWithTag("Player").GetComponent<CameraMovement>().enabled = true;
        GameObject.FindWithTag("Player").GetComponent<PlayerMovement>().enabled = true;
        Time.timeScale = 1;
    }
	
    public void Settings ()
    {
        settings.SetActive(true);
        pausemenu.SetActive(false);
    }

    public void ReturnToPauseMenu ()
    {
        settings.SetActive(false);
        pausemenu.SetActive(true);
    }

    public void QuitGame ()
    {
        Application.Quit();
    }

    public void SensitivitySlider ()
    {
        sensitivityHolder = GameObject.Find("SensitivitySlider").GetComponent<Slider>().value;
        sensitivity.text = sensitivityHolder.ToString();
        GameObject.FindWithTag("Player").GetComponent<CameraMovement>().sensitivity = sensitivityHolder;
    }

    public void BrightnessSlider ()
    {
        brightnessHolder = GameObject.Find("BrightnessSlider").GetComponent<Slider>().value;
        brightness.text = brightnessHolder.ToString();
        GameObject.Find("Directional Light").GetComponent<Light>().intensity = brightnessHolder;
    }

    public void FieldOfViewSlider ()
    {
        FOVHolder = GameObject.Find("FOVSlider").GetComponent<Slider>().value;
        FOV.text = FOVHolder.ToString();
        GameObject.Find("MainCamera").GetComponent<Camera>().fieldOfView = FOVHolder;
    }

    public void CloseCardChange ()
    {
        changeCard.SetActive(false);
        GameObject.FindWithTag("Player").GetComponent<CameraMovement>().enabled = true;
        GameObject.FindWithTag("Player").GetComponent<PlayerMovement>().enabled = true;
        Time.timeScale = 1;
    }

    public void ChangeToDamageCard()
    {
        player.GetComponent<PlayerShootBuildCard>().enabled = false;
        player.GetComponent<PlayerShootLightCard>().enabled = false;
        player.GetComponent<PlayerShootDamageCard>().enabled = true;
    }

    public void ChangeToBuildCard()
    {
        player.GetComponent<PlayerShootBuildCard>().enabled = true;
        player.GetComponent<PlayerShootLightCard>().enabled = false;
        player.GetComponent<PlayerShootDamageCard>().enabled = false;
    }

    public void ChangeToLightCard()
    {
        player.GetComponent<PlayerShootBuildCard>().enabled = false;
        player.GetComponent<PlayerShootLightCard>().enabled = true;
        player.GetComponent<PlayerShootDamageCard>().enabled = false;
    }
}
