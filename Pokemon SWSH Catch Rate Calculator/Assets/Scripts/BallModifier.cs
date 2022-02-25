using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallModifier : MonoBehaviour
{
    private int[] ballModifier1 = new int[] { 0, 10, 11, 13, 15, 18 };
    private int[] ballModifier2 = new int[] { 1, 4, 24 };

    private CatchRateCalculator catchRateCalculator;
    private PokemonSelector pokemonSelector;

    private bool netBall;
    private bool dreamBall;
    private bool fastBall;
    private bool isAsleep;
    private bool nestBall;
    private bool heavyBall;
    private bool levelBall;
    private bool moonBall;
    private int wPokemon;
    private int pLevel;

    [SerializeField]
    private GameObject waterToggle;

    [SerializeField]
    private GameObject wildLevel;   

    [SerializeField]
    private GameObject caughtBefore;    
    
    [SerializeField]
    private GameObject numTurns;    
    
    [SerializeField]
    private GameObject isDark;    
    
    [SerializeField]
    private GameObject isFirstTurn;    
    
    [SerializeField]
    private GameObject pokemonLevel;

    [SerializeField]
    private GameObject oppositeGender;

    [SerializeField]
    private GameObject isFishing;

    // Creates a getter and setter for "Is Asleep"
    public bool IsAsleep
    {
        get
        {
            return isAsleep;
        }
        set
        {
            isAsleep = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        netBall = false;
        dreamBall = false;
        fastBall = false;
        nestBall = false;
        heavyBall = false;
        levelBall = false;
        moonBall = false;
        isAsleep = false;
    }

    // Update is called once per frame
    void Update()
    {        
        catchRateCalculator = this.GetComponent<CatchRateCalculator>();
        pokemonSelector = this.GetComponent<PokemonSelector>();
        NetBallModifier();
        DreamBallModifier();
        FastBallModifier();
        HeavyBallModifier();
        MoonBallModifier();

        Debug.Log(catchRateCalculator.BallModifier);
    }

    public void ChosenBall(int value)
    {
        foreach (int n in ballModifier1 )
        {
            if (n == value)
            {
                NetBallFalse();
                DiveBallFalse();
                NestBallFalse();
                RepeatBallFalse();
                TimerBallFalse();
                DuskBallFalse();
                QuickBallFalse();
                DreamBallFalse();
                FastBallFalse();
                HeavyBallFalse();
                LevelBallFalse();
                LoveBallFalse();
                LureBallFalse();
                MoonBallFalse();

                catchRateCalculator.BallModifier = 1f;
                break;
            }
            else
            {
                foreach (int x in ballModifier2)
                {
                    if (x == value)
                    {
                        NetBallFalse();
                        DiveBallFalse();
                        NestBallFalse();
                        RepeatBallFalse();
                        TimerBallFalse();
                        DuskBallFalse();
                        QuickBallFalse();
                        DreamBallFalse();
                        FastBallFalse();
                        HeavyBallFalse();
                        LevelBallFalse();
                        LoveBallFalse();
                        LureBallFalse();
                        MoonBallFalse();

                        catchRateCalculator.BallModifier = 1.5f;
                        break;
                    }
                }
            }
        }

        if (value == 2)
        {
            NetBallFalse();
            DiveBallFalse();
            NestBallFalse();
            RepeatBallFalse();
            TimerBallFalse();
            DuskBallFalse();
            QuickBallFalse();
            DreamBallFalse();
            FastBallFalse();
            HeavyBallFalse();
            LevelBallFalse();
            LoveBallFalse();
            LureBallFalse();
            MoonBallFalse();

            catchRateCalculator.BallModifier = 2f;
        }
        else if (value == 3)
        {
            NetBallFalse();
            DiveBallFalse();
            NestBallFalse();
            RepeatBallFalse();
            TimerBallFalse();
            DuskBallFalse();
            QuickBallFalse();
            DreamBallFalse();
            FastBallFalse();
            HeavyBallFalse();
            LevelBallFalse();
            LoveBallFalse();
            LureBallFalse();
            MoonBallFalse();

            catchRateCalculator.IsMasterBall = true;
        }
        else if (value == 5)
        {
            DiveBallFalse();
            NestBallFalse();
            RepeatBallFalse();
            TimerBallFalse();
            DuskBallFalse();
            QuickBallFalse();
            DreamBallFalse();
            FastBallFalse();
            HeavyBallFalse();
            LevelBallFalse();
            LoveBallFalse();
            LureBallFalse();
            MoonBallFalse();

            NetBall();
        }
        else if (value == 6)
        {
            NetBallFalse();
            NestBallFalse();
            RepeatBallFalse();
            TimerBallFalse();
            DuskBallFalse();
            QuickBallFalse();
            DreamBallFalse();
            FastBallFalse();
            HeavyBallFalse();
            LevelBallFalse();
            LoveBallFalse();
            LureBallFalse();
            MoonBallFalse();

            DiveBall();
        }
        else if (value == 7)
        {
            NetBallFalse();
            DiveBallFalse();
            RepeatBallFalse();
            TimerBallFalse();
            DuskBallFalse();
            QuickBallFalse();
            DreamBallFalse();
            FastBallFalse();
            HeavyBallFalse();
            LevelBallFalse();
            LoveBallFalse();
            LureBallFalse();
            MoonBallFalse();

            NestBall();
        }
        else if (value == 8)
        {
            NetBallFalse();
            DiveBallFalse();
            NestBallFalse();
            TimerBallFalse();
            DuskBallFalse();
            QuickBallFalse();
            DreamBallFalse();
            FastBallFalse();
            HeavyBallFalse();
            LevelBallFalse();
            LoveBallFalse();
            LureBallFalse();
            MoonBallFalse();

            RepeatBall();
        }
        else if (value == 9)
        {
            NetBallFalse();
            DiveBallFalse();
            NestBallFalse();
            RepeatBallFalse();
            DuskBallFalse();
            QuickBallFalse();
            DreamBallFalse();
            FastBallFalse();
            HeavyBallFalse();
            LevelBallFalse();
            LoveBallFalse();
            LureBallFalse();
            MoonBallFalse();

            TimerBall();
        }
        else if (value == 12)
        {
            NetBallFalse();
            DiveBallFalse();
            NestBallFalse();
            RepeatBallFalse();
            TimerBallFalse();
            QuickBallFalse();
            DreamBallFalse();
            FastBallFalse();
            HeavyBallFalse();
            LevelBallFalse();
            LoveBallFalse();
            LureBallFalse();
            MoonBallFalse();

            DuskBall();
        }
        else if (value == 14)
        {
            NetBallFalse();
            DiveBallFalse();
            NestBallFalse();
            RepeatBallFalse();
            TimerBallFalse();
            DuskBallFalse();
            DreamBallFalse();
            FastBallFalse();
            HeavyBallFalse();
            LevelBallFalse();
            LoveBallFalse();
            LureBallFalse();
            MoonBallFalse();

            QuickBall();
        }
        else if (value == 16)
        {
            NetBallFalse();
            DiveBallFalse();
            NestBallFalse();
            RepeatBallFalse();
            TimerBallFalse();
            DuskBallFalse();
            QuickBallFalse();
            DreamBallFalse();
            FastBallFalse();
            HeavyBallFalse();
            LevelBallFalse();
            LoveBallFalse();
            LureBallFalse();
            MoonBallFalse();

            DreamBall();
        }
        else if (value == 17)
        {
            NetBallFalse();
            DiveBallFalse();
            NestBallFalse();
            RepeatBallFalse();
            TimerBallFalse();
            DuskBallFalse();
            QuickBallFalse();
            DreamBallFalse();
            HeavyBallFalse();
            LevelBallFalse();
            LoveBallFalse();
            LureBallFalse();
            MoonBallFalse();

            FastBall();
        }
        else if (value == 19)
        {
            NetBallFalse();
            DiveBallFalse();
            NestBallFalse();
            RepeatBallFalse();
            TimerBallFalse();
            DuskBallFalse();
            QuickBallFalse();
            DreamBallFalse();
            FastBallFalse();
            LevelBallFalse();
            LoveBallFalse();
            LureBallFalse();
            MoonBallFalse();

            HeavyBall();
        }
        else if (value == 20)
        {
            NetBallFalse();
            DiveBallFalse();
            NestBallFalse();
            RepeatBallFalse();
            TimerBallFalse();
            DuskBallFalse();
            QuickBallFalse();
            DreamBallFalse();
            FastBallFalse();
            HeavyBallFalse();
            LoveBallFalse();
            LureBallFalse();
            MoonBallFalse();

            LevelBall();
        }
        else if (value == 21)
        {
            NetBallFalse();
            DiveBallFalse();
            NestBallFalse();
            RepeatBallFalse();
            TimerBallFalse();
            DuskBallFalse();
            QuickBallFalse();
            DreamBallFalse();
            FastBallFalse();
            HeavyBallFalse();
            LevelBallFalse();
            LureBallFalse();
            MoonBallFalse();

            LoveBall();
        }
        else if (value == 22)
        {
            NetBallFalse();
            DiveBallFalse();
            NestBallFalse();
            RepeatBallFalse();
            TimerBallFalse();
            DuskBallFalse();
            QuickBallFalse();
            DreamBallFalse();
            FastBallFalse();
            HeavyBallFalse();
            LevelBallFalse();
            LoveBallFalse();
            MoonBallFalse();

            LureBall();
        }
        else if (value == 23)
        {
            NetBallFalse();
            DiveBallFalse();
            NestBallFalse();
            RepeatBallFalse();
            TimerBallFalse();
            DuskBallFalse();
            QuickBallFalse();
            DreamBallFalse();
            FastBallFalse();
            HeavyBallFalse();
            LevelBallFalse();
            LoveBallFalse();
            LureBallFalse();

            MoonBall();
        }
        else if (value == 25)
        {

            NetBallFalse();
            DiveBallFalse();
            NestBallFalse();
            RepeatBallFalse();
            TimerBallFalse();
            DuskBallFalse();
            QuickBallFalse();
            DreamBallFalse();
            FastBallFalse();
            HeavyBallFalse();
            LevelBallFalse();
            LoveBallFalse();
            LureBallFalse();
            MoonBallFalse();

            catchRateCalculator.BallModifier = 0.1f;
        }
    }

    void NetBall()
    {
        netBall = true;
    }

    void NetBallFalse()
    {
        netBall = false;
    }

    void NetBallModifier()
    {
        if (netBall == true)
        {
            if (pokemonSelector.Pokemon.Type1 == "Water" || pokemonSelector.Pokemon.Type1 == "Bug" || pokemonSelector.Pokemon.Type2 == "Water" || pokemonSelector.Pokemon.Type2 == "Bug")
            {
                catchRateCalculator.BallModifier = 3.5f;
            }
            else
            {
                catchRateCalculator.BallModifier = 1f;
            }
        }
    }

    void DiveBall()
    {
        waterToggle.SetActive(true);
        catchRateCalculator.BallModifier = 1f;
    }
    
    void DiveBallFalse()
    {
        waterToggle.SetActive(false);
    }

    public void IsWater(bool value)
    {
        if (value == true)
        {
            catchRateCalculator.BallModifier = 3.5f;
        }
        else
        {
            catchRateCalculator.BallModifier = 1f;
        }
    }

    void NestBall()
    {
        wildLevel.SetActive(true);
        nestBall = true;
        catchRateCalculator.BallModifier = 1f;
    }
    
    void NestBallFalse()
    {
        wildLevel.SetActive(false);
        nestBall = false;
    }

    public void WildLevel(string value)
    {
        if (nestBall == true)
        {
            int wildLevel = int.Parse(value);
            catchRateCalculator.BallModifier = ((40 - wildLevel) / 10);
            if (catchRateCalculator.BallModifier < 1)
            {
                catchRateCalculator.BallModifier = 1;
            }
            else if (catchRateCalculator.BallModifier > 3)
            {
                catchRateCalculator.BallModifier = 3;
            }
        }
        else if (levelBall == true)
        {
            wPokemon = int.Parse(value);

            if ((pLevel / 4) > wPokemon)
            {
                catchRateCalculator.BallModifier = 8f;
            }
            else if ((pLevel / 2) > wPokemon)
            {
                catchRateCalculator.BallModifier = 4f;
            }
            else if (pLevel > wPokemon)
            {
                catchRateCalculator.BallModifier = 2f;
            }
        }
    }

    void RepeatBall()
    {
        caughtBefore.SetActive(true);
        catchRateCalculator.BallModifier = 1f;
    }

    void RepeatBallFalse()
    {
        caughtBefore.SetActive(false);
    }

    public void CaughtBefore(bool value)
    {
        if (value == true)
        {
            catchRateCalculator.BallModifier = 3f;
        }
        else
        {
            catchRateCalculator.BallModifier = 1f;
        }
    }

    void TimerBall()
    {
        numTurns.SetActive(true);
        catchRateCalculator.BallModifier = 1;
    }

    void TimerBallFalse()
    {
        numTurns.SetActive(false);
    }

    public void NumTurns(string value)
    {
        int numTurn = int.Parse(value);
        catchRateCalculator.BallModifier = ((numTurn + 10) / 10);
        if (catchRateCalculator.BallModifier > 4)
        {
            catchRateCalculator.BallModifier = 4;
        }

    }

    void DuskBall()
    {
        isDark.SetActive(true);
        catchRateCalculator.BallModifier = 1f;
    }

    void DuskBallFalse()
    {
        isDark.SetActive(false);
    }

    public void IsDark(bool value)
    {
        if (value == true)
        {
            catchRateCalculator.BallModifier = 3f;
        }
        else
        {
            catchRateCalculator.BallModifier = 1f;
        }
    }

    void QuickBall()
    {
        isFirstTurn.SetActive(true);
        catchRateCalculator.BallModifier = 1f;
    }

    void QuickBallFalse()
    {
        isFirstTurn.SetActive(false);
    }

    public void IsFirstTurn(bool value)
    {
        if (value == true)
        {
            catchRateCalculator.BallModifier = 4f;
        }
        else
        {
            catchRateCalculator.BallModifier = 1f;
        }
    }

    void DreamBall()
    {
        dreamBall = true;
    }

    void DreamBallFalse()
    {
        dreamBall = false;
    }

    void DreamBallModifier()
    {
        if (dreamBall == true)
        {
            if (isAsleep == true)
            {
                catchRateCalculator.BallModifier = 4f;
            }
            else
            {
                catchRateCalculator.BallModifier = 1f;
            }
        }
    }

    void FastBall()
    {
        fastBall = true;
    }

    void FastBallFalse()
    {
        fastBall = false;
    }

    void FastBallModifier()
    {
        if (fastBall == true)
        {
            if (pokemonSelector.Pokemon.Speed >= 100)
            {
                Debug.Log(pokemonSelector.Pokemon.Speed);
                catchRateCalculator.BallModifier = 4f;
            }
            else
            {
                Debug.Log(pokemonSelector.Pokemon.Speed);
                catchRateCalculator.BallModifier = 1f;
            }
        }
    }

    void HeavyBall()
    {
        heavyBall = true;
        catchRateCalculator.BallModifier = 1f;
    }

    void HeavyBallFalse()
    {
        heavyBall = false;
    }

    void HeavyBallModifier()
    {
        if (heavyBall == true)
        {
            if (pokemonSelector.Pokemon.Weight < 451.1)
            {
                catchRateCalculator.CatchRate -= 20;
            }
            else if (pokemonSelector.Pokemon.Weight > 451.1 && pokemonSelector.Pokemon.Weight < 677.3)
            {
                catchRateCalculator.CatchRate += 20;
            }
            else if (pokemonSelector.Pokemon.Weight > 677.3 && pokemonSelector.Pokemon.Weight < 903)
            {
                catchRateCalculator.CatchRate += 30;
            }
            else if (pokemonSelector.Pokemon.Weight > 903)
            {
                catchRateCalculator.CatchRate += 40;
            }
        }
    }

    void LevelBall()
    {
        pokemonLevel.SetActive(true);
        wildLevel.SetActive(true);
        levelBall = true;
        catchRateCalculator.BallModifier = 2f;
    }

    void LevelBallFalse()
    {
        pokemonLevel.SetActive(false);
        wildLevel.SetActive(false);
        levelBall = false;
    }

    public void PokemonLevel(string value)
    {
        pLevel = int.Parse(value);

        if ((pLevel / 4) > wPokemon)
        {
            catchRateCalculator.BallModifier = 8f;
        }
        else if ((pLevel / 2) > wPokemon)
        {
            catchRateCalculator.BallModifier = 4f;
        }
        else if (pLevel > wPokemon)
        {
            catchRateCalculator.BallModifier = 2f;
        }
    }

    void LoveBall()
    {
        oppositeGender.SetActive(true);
        catchRateCalculator.BallModifier = 1f;
    }

    void LoveBallFalse()
    {
        oppositeGender.SetActive(false);
    }

    public void OppositeGender(bool value)
    {
        if (value == true)
        {
            catchRateCalculator.BallModifier = 8f;
        }
        else
        {
            catchRateCalculator.BallModifier = 1f;
        }
    }

    void LureBall()
    {
        isFishing.SetActive(true);
        catchRateCalculator.BallModifier = 1f;
    }

    void LureBallFalse()
    {
        isFishing.SetActive(false);
    }

    public void IsFishing(bool value)
    {
        if (value == true)
        {
            catchRateCalculator.BallModifier = 3f;
        }
        else
        {
            catchRateCalculator.BallModifier = 1f;
        }
    }

    void MoonBall()
    {
        moonBall = true;
    }

    void MoonBallFalse()
    {
        moonBall = false;
    }

    void MoonBallModifier()
    {
        if (moonBall == true)
        {
            if (pokemonSelector.Pokemon.MoonStone == true)
            {
                catchRateCalculator.BallModifier = 4f;
            }
            else
            {
                catchRateCalculator.BallModifier = 1f;
            }
        }
    }
}
