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

    // SOLAR TANK STATS
    public float currentSolarTankLevel = 20;
    public float maximumSolarTankLevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("n"))
        {
            AddWater(50);
        }
    }

    public void FillWaterTank(int rainStrength)
    {
        if (currentWaterTankLevel < maximumWaterTankLevel)
        {
            currentWaterTankLevel += rainStrength * Time.deltaTime;
        }
    }

    public void FillSolarTank(int sunStrength)
    {
        if (currentSolarTankLevel < maximumSolarTankLevel)
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

}
