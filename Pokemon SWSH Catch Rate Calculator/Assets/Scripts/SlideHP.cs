using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideHP : MonoBehaviour
{
    private CatchRateCalculator catchRateCalculator;

    // Update is called once per frame
    void Update()
    {
        catchRateCalculator = this.GetComponent<CatchRateCalculator>();
    }

    // Sets the percentage of "HP Percentage" depending on the slider value
    public void HpPercentageSlider(float val)
    {
        catchRateCalculator.HpPercentage = val;
    }

}
