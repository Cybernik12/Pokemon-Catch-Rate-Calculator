using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatusEffects : MonoBehaviour
{
    // Array holding the value for every status condition
    private float[] statusAffects = new float[] { 1f, 1.5f, 1.5f, 1.5f, 2.5f, 2.5f }; // None, Poison, Burn, Paralysis, Sleep, Frozen

    private CatchRateCalculator catchRateCalculator;
    private BallModifier ballModifier;

    // Update is called once per frame
    void Update()
    {
        catchRateCalculator = this.GetComponent<CatchRateCalculator>();
        ballModifier = this.GetComponent<BallModifier>();
    }

    public void HandleInputData(int value)
    {
        catchRateCalculator.StatusModifier = statusAffects[value];
        
        if (value == 4)
        {
            ballModifier.IsAsleep = true;
        }
        else
        {
            ballModifier.IsAsleep = false;
        }
    }

}
