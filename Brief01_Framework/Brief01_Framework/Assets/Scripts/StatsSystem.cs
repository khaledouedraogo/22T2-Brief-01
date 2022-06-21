using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our stats system, so that includes logic to handle generating starting physical stats
/// calculating our dancing stats based on physical stats and our stat multipliers.
/// </summary>
public class StatsSystem : MonoBehaviour
{
    /// Our physical stats that determine our dancing stats.
    public int agility;
    public int intelligence;
    public int strength;

    // Our variables used to determine our fighting power.
    public int style;
    public int luck;
    public int rhythm;

    private void Start()
    {
        // set out agility, strength and intelligence to a random number between zero and ten.
        agility = Random.Range(0, 11);
        Debug.Log(agility);
        intelligence = Random.Range(0, 11);
        Debug.Log(intelligence);
        strength = Random.Range(0,11);
        Debug.Log(strength);
        // BONUS! let's try taking our stats away from a pool of stats, i.e. 20 total, distributing this amoungst all the stats.
        strength = 0;
        agility = 0;
        intelligence = 0;

        // Debug out your current physical stat values (strength, agility, intelligence).
        Debug.Log(strength);
        Debug.Log(agility);
        Debug.Log(intelligence);

        // let's create some float temporary variables to hold our multiplier values.
        // create an agility multiplier should be set to 0.5
        float agilitymultiplier = 0.5f;

        // create a strength multiplier should be set to 1
        float strengthmultiplier = 1.0f;

        // create an intelligence multiplier should be set to 2.
        float intelligencemultiplier = 2.0f;

        // Debug out our current multiplier values.
        Debug.Log(agilitymultiplier);
        Debug.Log(strengthmultiplier);
        Debug.Log(intelligencemultiplier);

        // now that we have some stats and our multiplier values let's calculate our style, luck and ryhtmn based on these values.
        // style should be based off our strength and be converted at a rate of 1 : 1.
        style = 0;
        style += (int)strengthmultiplier;
        if(style >1)
        {
            style = (int)1.0f;
        }
        else if (style<1)
        {
            style = (int)1.0f;
        }

        

        // luck should be based off our intelligence and be converted at a rate of 1 : 1.5f
        luck = 0;
        luck += (int)intelligencemultiplier;
        if(luck > (int)1.5)
        {
            luck = (int)1.5f;
        }
        else if(luck < 1.0)
        {
            luck  = (int)1.0f;
        }
        // rhythm should be based off our agility and be converted at a rate of 1 : 0.5.
        rhythm = 0;
        rhythm = rhythm + (int)agilitymultiplier;
        if (rhythm > 1)
        {
            rhythm = (int)1.0f;
        }
        else if (rhythm < 0.5)
        {
            rhythm = (int)0.5f;
        }

        // Debug out our current dancing stat values (style, luck, rhythm)
        Debug.Log(style);
        Debug.Log(luck);
        Debug.Log(rhythm);

        // now let's imagine that our level has increased; and we've been granted 10 new stat points.
        // let's distribute those stats amoungst our strength and agility and intelligence.
        int additionalPoints = 10;
        agility = agility + additionalPoints;
        intelligence = intelligence + additionalPoints;
        strength = strength + additionalPoints;

        // Debug out our new physical stat values
        Debug.Log(agility);
        Debug.Log(intelligence);
        Debug.Log(strength);

        // let's recalculate our style, luck and rhytmn as our initial stats have changed.
        style = style + (int)strengthmultiplier;
        luck = luck + (int)agilitymultiplier;
        rhythm = rhythm + (int)intelligencemultiplier;
        // Debug out our new dancing stat values
        Debug.Log(style);
        Debug.Log(luck);
        Debug.Log(rhythm);
    }   
}
