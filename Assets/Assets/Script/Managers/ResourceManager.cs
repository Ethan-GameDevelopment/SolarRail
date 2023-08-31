using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    // CONNECTIONS

    public GameObject environmentManager;

    // TANKS // 

    // WATER TANK STATS
    public float currentWaterTankLevel = 100;
    public float maximumWaterTankLevel;

    public bool waterNutrientsStatus = false;

    // SOLAR TANK STATS
    public float currentSolarTankLevel = 20;
    public float maximumSolarTankLevel;

    public bool solarPanelStatus = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // OVERFLOW STOPPERS
        if (currentSolarTankLevel > maximumSolarTankLevel)
        { currentSolarTankLevel = maximumSolarTankLevel;}
        
        if(currentWaterTankLevel > maximumWaterTankLevel)
        { currentWaterTankLevel=maximumWaterTankLevel;}


    }
    

    // Functions is called when I tell them to
    public void FillWaterTank(int rainStrength)
    {
        if (currentWaterTankLevel < maximumWaterTankLevel)
        {
            currentWaterTankLevel += rainStrength * Time.deltaTime;
        }
    }

    public void FillSolarTank(int sunStrength)
    {
        if ((currentSolarTankLevel < maximumSolarTankLevel) && (solarPanelStatus == true))
        {
            currentSolarTankLevel += sunStrength * Time.deltaTime;
        }
    }

    public void AddWater(int amount)
    {
        if (amount <= (maximumWaterTankLevel - currentWaterTankLevel))
        {
            currentWaterTankLevel += amount;
        } else
        {
            currentWaterTankLevel = maximumWaterTankLevel;
        }
    }

    public void TogglePanel()
    {
        if (solarPanelStatus)
        {
            solarPanelStatus = false;
        }
        else
        {
            solarPanelStatus = true;
        }
    }

    public void ToggleNutrients()
    {
        if (waterNutrientsStatus)
        {
            waterNutrientsStatus = false;
        }
        else
        {
            waterNutrientsStatus = true;
        }
    }

}
