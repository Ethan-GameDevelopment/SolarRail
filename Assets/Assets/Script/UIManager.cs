using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    public GameObject gameManager;
    public GameObject resourceManager;
    public GameObject environmentManager;
    
    // TEXT
    
    public TextMeshProUGUI currentWeatherUIText;
    
    public TextMeshProUGUI watertankCurrentUIText;
    public TextMeshProUGUI watertankMaxUIText;


    public string debugCurrentWeather;

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


    }

 


}
