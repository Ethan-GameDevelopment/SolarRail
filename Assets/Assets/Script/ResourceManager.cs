using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    // CONNECTIONS

    public GameObject environmentManager;

    // TANKS

    public float currentWaterTankLevel = 100;
    public float maximumWaterTankLevel = 500;

    public int currentSolarTankLevel = 20;
    public int maximumSolarTankLevel = 500;

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

    public void FillWaterTank(int RainStrength)
    {
        if (currentWaterTankLevel < maximumWaterTankLevel)
        {
            currentWaterTankLevel += RainStrength * Time.deltaTime;
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
