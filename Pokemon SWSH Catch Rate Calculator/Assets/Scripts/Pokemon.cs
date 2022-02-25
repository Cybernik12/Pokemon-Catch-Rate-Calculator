using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon
{
    /*
    HP
    Speed
    CaptureRate
    Type
    Weight
    If it evolves using a moon stone
    */

    int hp;
    int captureRate;
    int speed;
    float weight;
    string type1;
    string type2;
    bool moonStone;

    public int HP
    {
        get
        {
            return hp;
        }
    }
    public int CaptureRate
    {
        get
        {
            return captureRate;
        }
    }
    public int Speed
    {
        get
        {
            return speed;
        }
    }
    public float Weight
    {
        get
        {
            return weight;
        }
    }
    public string Type1
    {
        get
        {
            return type1;
        }
    }
    public string Type2
    {
        get
        {
            return type2;
        }
    }
    public bool MoonStone
    {
        get
        {
            return moonStone;
        }
    }

    public Pokemon(int hp, int captureRate, int speed,  float weight, string type1, string type2, bool moonStone)
    {
        this.hp = hp;
        this.captureRate = captureRate;
        this.speed = speed;
        this.weight = weight;
        this.type1 = type1;
        this.type2 = type2;
        this.moonStone = moonStone;
    }

}
