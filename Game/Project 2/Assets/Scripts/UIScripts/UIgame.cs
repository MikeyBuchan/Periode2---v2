using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIgame : MonoBehaviour
{
    public GameObject pausemenu;
    public GameObject settings;
    public GameObject enemySpawner;
    public GameObject nextWave;
    public GameObject sensitivitySlider;
    public GameObject fOVSlider;
    public GameObject brightnessSlider;
    private float sensitivityHolder;
    private float brightnessHolder;
    private float FOVHolder;
    public Text sensitivity;
    public Text brightness;
    public Text FOV;
    public Text enemiesLeftText;


    void Update()
    {
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

        enemiesLeftText.text = "Ghosts left: " + GameObject.FindWithTag("EnemySpawner").GetComponent<EnemySpawner>().enemiesLeft.ToString();

        if (GameObject.FindWithTag("EnemySpawner").GetComponent<EnemySpawner>().enemiesLeft <= 0)
        {
            nextWave.SetActive(true);
        }
        else
        {
            nextWave.SetActive(false);
        }

        if (Input.GetButtonDown("Cancel"))
        {
            pausemenu.SetActive(true);
            GameObject.FindWithTag("Player").GetComponent<CameraMovement>().enabled = false;
            GameObject.FindWithTag("Player").GetComponent<PlayerMovement>().enabled = false;
            Time.timeScale = 0;
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
        sensitivityHolder = sensitivitySlider.GetComponent<Slider>().value;
        sensitivity.text = sensitivityHolder.ToString();
        GameObject.FindWithTag("Player").GetComponent<CameraMovement>().sensitivity = sensitivityHolder;
    }

    public void BrightnessSlider ()
    {
        brightnessHolder = brightnessSlider.GetComponent<Slider>().value;
        brightness.text = brightnessHolder.ToString();
        GameObject.FindWithTag("SunLight").GetComponent<Light>().intensity = brightnessHolder;
    }

    public void FieldOfViewSlider ()
    {
        FOVHolder = fOVSlider.GetComponent<Slider>().value;
        FOV.text = FOVHolder.ToString();
        GameObject.FindWithTag("MainCamera").GetComponent<Camera>().fieldOfView = FOVHolder;
    }

    public void ChangeToDamageCard()
    {
        GameObject.FindWithTag("Player").GetComponent<PlayerShootBuildCard>().enabled = false;
        GameObject.FindWithTag("Player").GetComponent<PlayerShootLightCard>().enabled = false;
        GameObject.FindWithTag("Player").GetComponent<PlayerShootDamageCard>().enabled = true;
    }

    public void ChangeToBuildCard()
    {
        GameObject.FindWithTag("Player").GetComponent<PlayerShootBuildCard>().enabled = true;
        GameObject.FindWithTag("Player").GetComponent<PlayerShootLightCard>().enabled = false;
        GameObject.FindWithTag("Player").GetComponent<PlayerShootDamageCard>().enabled = false;
    }

    public void ChangeToLightCard()
    {
        GameObject.FindWithTag("Player").GetComponent<PlayerShootBuildCard>().enabled = false;
        GameObject.FindWithTag("Player").GetComponent<PlayerShootLightCard>().enabled = true;
        GameObject.FindWithTag("Player").GetComponent<PlayerShootDamageCard>().enabled = false;
    }
}
