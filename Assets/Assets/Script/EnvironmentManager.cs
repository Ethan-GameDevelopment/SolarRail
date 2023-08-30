using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentManager : MonoBehaviour
{
    //CONNECTIONS

    public GameObject gameManager;
    public GameObject resourceManager;
    
    //LISTS

    private List<string> possibleWeather;
    private List<string> possibleBiome;

    //VARIABLES

    public string currentWeather;
    private string currentBiome;

    public int rainStrength = 5;
    public int sunStrength = 1;

    public bool isRaining = false;
    public bool isSunny = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("r"))
        {
            RandomiseWeather();
        }

        // RAIN FILL WATER TANK WHEN RAINING
        if(isRaining)
        {
            currentWeather = "Raining";
            resourceManager.GetComponent<ResourceManager>().FillWaterTank(rainStrength);
        } else
        {
            currentWeather = "Clear";
        }

        // SUN FILL SOLAR TANK WHEN SUNNY
        if (isSunny)
        {
            // currentWeather = "Sunny";
            resourceManager.GetComponent<ResourceManager>().FillSolarTank(sunStrength);
        }
       

    }

    void RandomiseWeather()
    {
        currentWeather = possibleWeather[Random.Range(0, possibleWeather.Count)];
    }

    public string GetWeatherStatus()
    {
        return currentWeather;
    }

    public void ToggleRain()
    {
        if(isRaining)
        {
            isRaining = false;
        } else
        {
            isRaining = true;
        }
    }

    public void ToggleSunlight()
    {
        if (isSunny)
        {
            isSunny = false;
        }
        else
        {
            isSunny = true;
        }
    }

}
