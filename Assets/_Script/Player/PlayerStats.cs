using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public string NameChar = "Player";
    bool gender = true;
    public string Character;
    int maxLv = 50;
    public int CurrentLv;
    int nextLv;
    int maxHP;
    public int CurrentHP;
    float maxEXP;
    public float CurrentEXP;

    private void Start()
    {        
        if (gender != true)
        {
            Character = "Ms." + NameChar;
        }
        else
        {
            Character = "Mr." + NameChar;
        }
        Debug.Log("Welcome " + Character);

        CurrentLv = Random.Range(0, maxLv);
        maxHP = CurrentLv * 24;
        maxEXP = CurrentLv * 1500;

        CurrentEXP = Random.Range(0, maxEXP);
        float expProgress = ((CurrentEXP / maxEXP)*100);
        nextLv = CurrentLv + 1;
        
        CurrentHP = Random.Range(0, maxHP);
        int damage = maxHP - CurrentHP;

        Debug.Log("Your Stats: ");
        Debug.Log($"Character: {Character}");
        Debug.Log($"Level: {CurrentLv}/{maxLv}");
        Debug.Log($"HP: {CurrentHP}/{maxHP}");
        Debug.Log($"EXP: {CurrentEXP}/{maxEXP}");

        Debug.Log(Mathf.Round(100 - expProgress) + "% to proceed to Level " + nextLv);
        Debug.Log($"You received: {damage} damage");
    }
}
