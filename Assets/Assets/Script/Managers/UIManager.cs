using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEditor;

public class UIManager : MonoBehaviour
{
    // CONNECTION //

    public GameObject gameManager;
    public GameObject resourceManager;
    public GameObject environmentManager;

    // TEXT // 
    
    // RESOURCE BARS //
    // WATER TANK
    public Slider WaterTankBar;
    public Texture positiveRain;
    public Texture negativeRain;
    public Texture positiveNutrients;
    public Texture negativeNutrients;
    public GameObject rainIndicator;
    public GameObject nutrientsIndicator;
    // SOLAR TANK
    public Slider SolarTankBar;
    public Texture positiveSun;
    public Texture negativeSun;
    public Texture positivePanel;
    public Texture negativePanel;
    public GameObject sunIndicator;
    public GameObject panelIndicator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // You know what Update() does ;)
    void Update()
    {
        
        // RESOURCE BARS //
        // WATER TANK
        // BAR
        WaterTankBar.maxValue = resourceManager.GetComponent<ResourceManager>().maximumWaterTankLevel;
        WaterTankBar.value = resourceManager.GetComponent<ResourceManager>().currentWaterTankLevel;
        // INDICATORS
        // RAIN
        if (environmentManager.GetComponent<EnvironmentManager>().isRaining)
        {
            rainIndicator.GetComponent<RawImage>().texture = positiveRain;
        } else
        {
            rainIndicator.GetComponent<RawImage>().texture = negativeRain;
        }
        // NUTRIENTS
        if (resourceManager.GetComponent<ResourceManager>().waterNutrientsStatus)
        {
            nutrientsIndicator.GetComponent<RawImage>().texture = positiveNutrients;
        } else
        {
            nutrientsIndicator.GetComponent<RawImage>().texture = negativeNutrients;
        }
        

        // SOLAR TANK
        // BAR
        SolarTankBar.maxValue = resourceManager.GetComponent<ResourceManager>().maximumSolarTankLevel;
        SolarTankBar.value = resourceManager.GetComponent<ResourceManager>().currentSolarTankLevel;
        // INDICATORS
        // RAIN
        if (environmentManager.GetComponent<EnvironmentManager>().isSunny)
        {
            sunIndicator.GetComponent<RawImage>().texture = positiveSun;
        }
        else
        {
            sunIndicator.GetComponent<RawImage>().texture = negativeSun;
        }
        // NUTRIENTS
        if (resourceManager.GetComponent<ResourceManager>().solarPanelStatus)
        {
            panelIndicator.GetComponent<RawImage>().texture = positivePanel;
        }
        else
        {
            panelIndicator.GetComponent<RawImage>().texture = negativePanel;
        }
    }

 


}
