// MIT license
// Alpha flashing text. A simple script.
// #NVJOB Nicholas Veselov (independent developer)


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AlphaFlashing : MonoBehaviour
{
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    public float minAlpha = 0.1f; // The minimum value of the alpha channel, from 0.
    public float maxAlpha = 0.9f; // The maximum value of the alpha channel, up to 1.
    public float timerAlpha = 0.0f; // The conditional time for changing the magnitude of the alpha channel value.

    //---------------------------------

    float minAlphaZ;
    float maxAlphaZ;
    float timerAlphaZ;
    float alphazxc;
    bool timertr = false;
    Color rezcolor;


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    void Start()
    {
        //---------------------------------

        alphazxc = minAlpha;
        minAlphaZ = minAlpha;
        maxAlphaZ = maxAlpha;
        timerAlphaZ = timerAlpha / 100.0f; // The conditional time.
        rezcolor = this.GetComponent<Text>().color; // The current value of the color of the text.

        //---------------------------------
    }


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    private void LateUpdate()
    {
        //---------------------------------

        if (timertr == false) // Increase the minimum value of the alpha channel, to the maximum.
        {
            minAlphaZ += timerAlphaZ * Time.deltaTime;
            alphazxc = minAlphaZ;
            if (minAlphaZ >= maxAlpha)
            {
                timertr = true;
                minAlphaZ = minAlpha;
            }
        }

        //---------------------------------

        if (timertr == true) // Decrease the maximum value of the alpha channel, to the minimum.
        {
            maxAlphaZ -= timerAlphaZ * Time.deltaTime;
            alphazxc = maxAlphaZ;
            if (maxAlphaZ <= minAlpha)
            {
                timertr = false;
                maxAlphaZ = maxAlpha;
            }
        }

        this.GetComponent<Text>().color = new Color(rezcolor.r, rezcolor.g, rezcolor.b, alphazxc);

        //---------------------------------
    }


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
}