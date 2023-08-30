using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentManager : MonoBehaviour
{
    //CONNECTIONS

    public GameObject gameManager;
    
    //LISTS

    private List<string> possibleWeather;
    private List<string> possibleBiome;

    //VARIABLES

    public string currentWeather;
    private string currentBiome;
    
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
    }

    void RandomiseWeather()
    {
        currentWeather = possibleWeather[Random.Range(0, possibleWeather.Count)];
    }

    public string GetWeatherStatus()
    {
        return currentWeather;
    }

}
