using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankBars : MonoBehaviour
{
    // CONNECTION

    public GameObject resourceManager;

    public Slider tankBar;

    public string tankType;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tankType == "Solar")
        {
            tankBar.maxValue = resourceManager.GetComponent<ResourceManager>().maximumSolarTankLevel;
            tankBar.value = resourceManager.GetComponent<ResourceManager>().currentSolarTankLevel;
        }
        if (tankType == "Water")
        {
            tankBar.maxValue = resourceManager.GetComponent<ResourceManager>().maximumWaterTankLevel;
            tankBar.value = resourceManager.GetComponent<ResourceManager>().currentWaterTankLevel;
        }
    }
}
