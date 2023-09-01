using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PowerCell : MonoBehaviour
{
    public int powerCellID;
    public float currentPowerCellLevel;
    public float maximumPowerCellLevel;

    public float maximumPowerCellSliceLevel;

    public List<float> powercellSlices;
    public List<GameObject> powercellSliceDisplays;

    public Color sliceColour;

    public int focusedSlice = 0;

    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        maximumPowerCellSliceLevel = maximumPowerCellLevel / 6;

        // CALCULATE CURRENTPOWERCELL LEVEL
        currentPowerCellLevel = powercellSlices[0] + powercellSlices[1] + powercellSlices[2] + powercellSlices[3] + powercellSlices[4] + powercellSlices[5];

        // SLICE LIGHTS
        for (int i = 0; i < 6; i++)
        {
            float sliceCharge = powercellSlices[i];

            float sliceChargeP = sliceCharge / 100;

            powercellSliceDisplays[i].GetComponent<MeshRenderer>().material.color = new Color(sliceColour.r, sliceColour.g, sliceColour.b, sliceChargeP);
        }

        // SWAP FOCUSSED & ADD/SUBTRACT SOLAR

        if(Input.GetKey("j"))
        {
            AdjustFocusedSlice(0, 5);
        }

        if (Input.GetKey("l"))
        {
            AdjustFocusedSlice(1, 10);
        }

        if (Input.GetKeyDown("k"))
        {
            SwapFocusedSlice();
        }
    }

    void SwapFocusedSlice()
    {
        if (focusedSlice < 5)
        {
            focusedSlice += 1;
        } else
        {
            focusedSlice = 0;
        }
    }

    void AdjustFocusedSlice(int direction, float amount)
    {
        if(direction == 1)
        {
            if (amount < (maximumPowerCellSliceLevel - powercellSlices[focusedSlice]))
            {
                powercellSlices[focusedSlice] += amount * Time.deltaTime;
            } else
            {
                powercellSlices[focusedSlice] = maximumPowerCellSliceLevel;
            }
        }
        
        if (direction == 0)
        {
            if (amount < powercellSlices[focusedSlice])
            {
                powercellSlices[focusedSlice] -= amount * Time.deltaTime;
            } else
            {
                powercellSlices[focusedSlice] = 0;
            }
        }
    }
}
