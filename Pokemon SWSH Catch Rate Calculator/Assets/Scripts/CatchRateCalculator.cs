using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CatchRateCalculator : MonoBehaviour
{
    private bool isMasterBall;

    private int maxHp;
    private int catchRate;

    private float hp;
    private float catchValue;
    private float ballModifier;
    private float statusModifier;
    private float hpPercentage;
    private float catchPercentage;

    [SerializeField]
    private TextMeshProUGUI percentageUI;

    private PokemonSelector pokemonSelector;

    // Creates a getter and setter for "Status Modifier"
    public float StatusModifier
    {
        get
        {
            return statusModifier;
        }
        set
        {
            statusModifier = value;
        }
    }

    // Creates a getter and setter for "HP Percentage"
    public float HpPercentage
    {
        get
        {
            return hpPercentage;
        }
        set
        {
            hpPercentage = value;
        }
    }    
    
    // Creates a getter and setter for "Ball Modifier"
    public float BallModifier
    {
        get
        {
            return ballModifier;
        }
        set
        {
            ballModifier = value;
        }
    }    
    
    // Creates a getter and setter for "Ball Modifier"
    public bool IsMasterBall
    {
        get
        {
            return isMasterBall;
        }
        set
        {
            isMasterBall = value;
        }
    }

    // Creates a getter and setter for "Catch Rate"
    public int CatchRate
    {
        get
        {
            return catchRate;
        }
        set
        {
            catchRate = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        isMasterBall = false;

        pokemonSelector = this.GetComponent<PokemonSelector>();

        // Grookey Test
        maxHp = pokemonSelector.Pokemon.HP;
        catchRate = pokemonSelector.Pokemon.CaptureRate;

        ballModifier = 1f;
        statusModifier = 1f;
        hpPercentage = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateVariables();
        HPCalculator();
        Calculator();

        percentageUI.text = "Catch Rate is: " + catchPercentage.ToString() + "%";
        Debug.Log(catchPercentage);
    }

    // Calculates the percentage chance of catching a pokemon
    void Calculator()
    {
        if (isMasterBall == true)
        {
            catchPercentage = 100f;
        }

        else
        {
            //Calculates the catch value
            catchValue = (((3 * maxHp - 2 * hp) * (catchRate * ballModifier) / (3 * maxHp)) * statusModifier);

            // Converts the catch calue into a percentage
            catchPercentage = (catchValue / 255) * 100;
        }
    }

    // Calculates the hp of the pokemon by percentage
    void HPCalculator()
    {
        hp = (maxHp / 100) * hpPercentage;
    }

    void UpdateVariables()
    {
        // Grookey Test
        maxHp = pokemonSelector.Pokemon.HP;
        catchRate = pokemonSelector.Pokemon.CaptureRate;
    }
}
