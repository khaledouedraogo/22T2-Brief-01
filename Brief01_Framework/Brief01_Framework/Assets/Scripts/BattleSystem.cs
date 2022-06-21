using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our battle system, so being able to calculate the percentage chance of us winning.
/// As well as determine which of the two characters has won a fight, or if it's a draw
/// </summary>
public class BattleSystem : MonoBehaviour
{
    private void Start()
    {
        // let's start by setting our player dancing stats to random numbers
        // style should be random between 1-10
        int playerOneStyle = 0;
        playerOneStyle =Random.Range(1,11);
        Debug.Log(playerOneStyle);
        // luck should be random between 0-4
        int playerOneLuck = 0;
        playerOneLuck = Random.Range(0, 5);
        Debug.Log(playerOneLuck);
        // ryhtm should be random between 1-6
        int playerOneRyhtm = 0;
        playerOneRyhtm =Random.Range(1, 7);
        Debug.Log(playerOneRyhtm);
        // style should be random between 1-10
        int playerTwoStyle = 0;
        playerTwoStyle = Random.Range(1, 11);
        Debug.Log(playerTwoStyle);
        // luck should be random between 0-4
        int playerTwoLuck = 0;
        playerTwoLuck = Random.Range(0, 5);
        Debug.Log(playerTwoLuck);
        // ryhtm should be random between 1-6
        int playerTwoRyhtm = 0;
        playerTwoRyhtm = Random.Range(1, 7);
        Debug.Log(playerTwoRyhtm);

        // let's set our player power levels, using an algorithm, the simpliest would be luck + style + rhythm
        // this algorthim should be the same for each character to keep it fair.
        int playerOnePowerLevel = 0;
        int playerTwoPowerLevel = 0;
        playerOnePowerLevel = (playerOneLuck + playerOneStyle + playerOneRyhtm);
        playerTwoPowerLevel = (playerTwoLuck + playerTwoStyle + playerTwoRyhtm);


        // Debug out the two players, power levels.
        Debug.Log(playerOnePowerLevel);
        Debug.Log(playerTwoPowerLevel);

        // calculate the percentage chance of winning the fight for each character.
        // todo this you'll need to add the two powers together, then divide you characters power against this and multiply the result by 100.
        int totalPower = 0;
        int playerOneChanceToWin = 0;
        int playerTwoChanceToWin = 0;
        totalPower = (playerOnePowerLevel + playerTwoPowerLevel);
        playerOneChanceToWin = ((playerOnePowerLevel / totalPower) * 100);
        playerTwoChanceToWin = ((playerTwoPowerLevel / totalPower) * 100);

        // Debug out the chance of each character to win.
        Debug.Log(playerOneChanceToWin);
        Debug.Log(playerTwoChanceToWin);

        int newXp;
        // We probably want to compare the powers of our characters and decide who has a higher power level; I just hope they aren't over 9000.  
        if (playerOnePowerLevel > playerTwoPowerLevel)
        // Debug out which character has won, which has lost, or if it's a draw. 
        {
            Debug.Log("PlayerOne has the Higher power level");
            newXp = (playerOneChanceToWin - playerTwoChanceToWin) * 10;
        }
        else if (playerOnePowerLevel < playerTwoPowerLevel)
        {
            Debug.Log("PlayerTwo has the Higher power level");
            newXp = (playerOneChanceToWin - playerTwoChanceToWin) * 10;


        }
        else 
        {
            Debug.Log(" It is a Draw, None of them won");
            newXp = 50;
        }

        // Debug out how much experience they should gain based on the difference of their chances to win, or if it's a draw award a default amount.
            Debug.Log(newXp);
    }

    

    

}
