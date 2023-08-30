using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public GameObject gameManager;
    public GameObject resourceManager;
    public GameObject environmentManager;
    
    // TEXT
    
    public TextMeshProUGUI currentWeatherUIText;
    
    public TextMeshProUGUI watertankCurrentUIText;
    public TextMeshProUGUI watertankMaxUIText;

    public TextMeshProUGUI solartankCurrentUIText;
    public TextMeshProUGUI solartankMaxUIText;

    public string debugCurrentWeather;

    // RESOURCE BARS

    public Slider WaterTankBar;
    public Slider SolarTankBar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // You know what Update() does ;)
    void Update()
    {
        currentWeatherUIText.text = environmentManager.GetComponent<EnvironmentManager>().GetWeatherStatus();

        watertankCurrentUIText.text = ""+resourceManager.GetComponent<ResourceManager>().currentWaterTankLevel+"L";
        watertankMaxUIText.text = ""+resourceManager.GetComponent<ResourceManager>().maximumWaterTankLevel +"L";

        solartankCurrentUIText.text = "" + resourceManager.GetComponent<ResourceManager>().currentSolarTankLevel + " Watts";
        solartankMaxUIText.text = "" + resourceManager.GetComponent<ResourceManager>().maximumSolarTankLevel + " Watts";

        // RESOURCE BARS // 

        // WATER TANK
        WaterTankBar.maxValue = resourceManager.GetComponent<ResourceManager>().maximumWaterTankLevel;
        WaterTankBar.value = resourceManager.GetComponent<ResourceManager>().currentWaterTankLevel;

        // WATER TANK
        SolarTankBar.maxValue = resourceManager.GetComponent<ResourceManager>().maximumSolarTankLevel;
        SolarTankBar.value = resourceManager.GetComponent<ResourceManager>().currentSolarTankLevel;

    }

 


}
