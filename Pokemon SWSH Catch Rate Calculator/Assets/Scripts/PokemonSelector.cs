using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonSelector : MonoBehaviour
{
    private Pokemon pokemon;

    public Pokemon Pokemon
    {
        get
        {
            return pokemon;
        }
    }

    void Awake()
    {
        pokemon = new Pokemon(157, 65, 40, 11.0f, "Grass", null, false);
    }

    // Start is called before the first frame update
    void Start()
    {
        // pokemon = new Pokemon(157, 45, 65, 11.0f, "Grass", null, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectedPokemon(int value)
    {

        /*
            HP
            Speed
            CaptureRate
            Type
            Weight
            If it evolves using a moon stone
        */

        if (value == 0) // Grookey
        {
            pokemon = new Pokemon(157, 40, 65, 11.0f, "Grass", null, false);
        }
        else if (value == 1) // Thwackey
        {
            pokemon = new Pokemon(177, 45, 80, 1000f, "Grass", null, true);
        }
        else if (value == 2) // Rillaboom
        {
            pokemon = new Pokemon(207, 45, 85, 198.4f, "Grass", null, false);
        }
    }

}
