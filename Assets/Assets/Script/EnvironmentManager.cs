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

    public int RainStrength = 5;

    public bool isRaining = false;

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

  
        if(isRaining)
        {
            currentWeather = "Raining";
            resourceManager.GetComponent<ResourceManager>().FillWaterTank(RainStrength);
        } else
        {
            currentWeather = "Clear";
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

}
