using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public Text LevelText;
    public Text ExpText;

    string levelKey = "PlayerLevel";
    string expKey = "CurrentExp";
    string nextLvlExpKey = "NextLevelExp";

    public void Awake()
    {
        var playerLvl = PlayerPrefs.GetInt(levelKey, 0);

        if (playerLvl != 0)
        {
            LevelText.text = PlayerPrefs.GetInt(levelKey).ToString();
            ExpText.text = PlayerPrefs.GetInt(expKey).ToString() + " / " + PlayerPrefs.GetInt(nextLvlExpKey).ToString();
        }
        else
        {
            PlayerPrefs.SetInt(levelKey, 1);
            PlayerPrefs.SetInt(expKey, 0);
            PlayerPrefs.SetInt(nextLvlExpKey, 100);

            LevelText.text = PlayerPrefs.GetInt(levelKey).ToString();
            ExpText.text = PlayerPrefs.GetInt(expKey).ToString() + " / " + PlayerPrefs.GetInt(nextLvlExpKey).ToString();
        }
    }

    public void Update()
    {
        // level up logic
        LevelUpLogic();
        
        // refresh the displayed player stats
        if (PlayerPrefs.HasKey(levelKey) && PlayerPrefs.HasKey(expKey) && PlayerPrefs.HasKey(nextLvlExpKey))
        {
            LevelText.text = PlayerPrefs.GetInt(levelKey).ToString();
            ExpText.text = PlayerPrefs.GetInt(expKey).ToString() + " / " + PlayerPrefs.GetInt(nextLvlExpKey).ToString();
        }
    }

    // TODO: this is quite messy, need to explore options to make this look nicer
    private void LevelUpLogic()
    {
        var playerLvl = PlayerPrefs.GetInt(levelKey);
        var currentExp = PlayerPrefs.GetInt(expKey);

        if (playerLvl == 1 && currentExp >= 100)
        {
            GlobalVariables.playerLevel = 2;
            GlobalVariables.currentExp = 0;
            GlobalVariables.nextLevelExp = 200;
            PlayerPrefs.SetInt(levelKey, GlobalVariables.playerLevel);
            PlayerPrefs.SetInt(expKey, GlobalVariables.currentExp);
            PlayerPrefs.SetInt(nextLvlExpKey, GlobalVariables.nextLevelExp);
        }

        if (playerLvl == 2 && currentExp >= 200)
        {
            GlobalVariables.playerLevel = 3;
            GlobalVariables.currentExp = 0;
            GlobalVariables.nextLevelExp = 400;
            PlayerPrefs.SetInt(levelKey, GlobalVariables.playerLevel);
            PlayerPrefs.SetInt(expKey, GlobalVariables.currentExp);
            PlayerPrefs.SetInt(nextLvlExpKey, GlobalVariables.nextLevelExp);
        }

        if (playerLvl == 3 && currentExp >= 400)
        {
            GlobalVariables.playerLevel = 4;
            GlobalVariables.currentExp = 0;
            GlobalVariables.nextLevelExp = 800;
            PlayerPrefs.SetInt(levelKey, GlobalVariables.playerLevel);
            PlayerPrefs.SetInt(expKey, GlobalVariables.currentExp);
            PlayerPrefs.SetInt(nextLvlExpKey, GlobalVariables.nextLevelExp);
        }

        if (playerLvl == 4 && currentExp >= 800)
        {
            GlobalVariables.playerLevel = 5;
            GlobalVariables.currentExp = 0;
            GlobalVariables.nextLevelExp = 1600;
            PlayerPrefs.SetInt(levelKey, GlobalVariables.playerLevel);
            PlayerPrefs.SetInt(expKey, GlobalVariables.currentExp);
            PlayerPrefs.SetInt(nextLvlExpKey, GlobalVariables.nextLevelExp);
        }

        if (playerLvl == 5 && currentExp >= 1600)
        {
            GlobalVariables.playerLevel = 6;
            GlobalVariables.currentExp = 0;
            GlobalVariables.nextLevelExp = 3200;
            PlayerPrefs.SetInt(levelKey, GlobalVariables.playerLevel);
            PlayerPrefs.SetInt(expKey, GlobalVariables.currentExp);
            PlayerPrefs.SetInt(nextLvlExpKey, GlobalVariables.nextLevelExp);
        }

        if (playerLvl == 6 && currentExp >= 3200)
        {
            GlobalVariables.playerLevel = 7;
            GlobalVariables.currentExp = 0;
            GlobalVariables.nextLevelExp = 6400;
            PlayerPrefs.SetInt(levelKey, GlobalVariables.playerLevel);
            PlayerPrefs.SetInt(expKey, GlobalVariables.currentExp);
            PlayerPrefs.SetInt(nextLvlExpKey, GlobalVariables.nextLevelExp);
        }

        if (playerLvl == 7 && currentExp >= 6400)
        {
            GlobalVariables.playerLevel = 8;
            GlobalVariables.currentExp = 0;
            GlobalVariables.nextLevelExp = 12800;
            PlayerPrefs.SetInt(levelKey, GlobalVariables.playerLevel);
            PlayerPrefs.SetInt(expKey, GlobalVariables.currentExp);
            PlayerPrefs.SetInt(nextLvlExpKey, GlobalVariables.nextLevelExp);
        }

        if (playerLvl == 8 && currentExp >= 12800)
        {
            GlobalVariables.playerLevel = 9;
            GlobalVariables.currentExp = 0;
            GlobalVariables.nextLevelExp = 25600;
            PlayerPrefs.SetInt(levelKey, GlobalVariables.playerLevel);
            PlayerPrefs.SetInt(expKey, GlobalVariables.currentExp);
            PlayerPrefs.SetInt(nextLvlExpKey, GlobalVariables.nextLevelExp);
        }

        if (playerLvl == 9 && currentExp >= 25600)
        {
            GlobalVariables.playerLevel = 10;
            GlobalVariables.currentExp = 0;
            GlobalVariables.nextLevelExp = 51200;
            PlayerPrefs.SetInt(levelKey, GlobalVariables.playerLevel);
            PlayerPrefs.SetInt(expKey, GlobalVariables.currentExp);
            PlayerPrefs.SetInt(nextLvlExpKey, GlobalVariables.nextLevelExp);
        }

        if (playerLvl == 10 && currentExp >= 51200)
        {
            GlobalVariables.playerLevel = 10;
            GlobalVariables.currentExp = 0;
            ExpText.text = "Max";
            PlayerPrefs.SetInt(levelKey, GlobalVariables.playerLevel);
            PlayerPrefs.SetInt(expKey, GlobalVariables.currentExp);
            PlayerPrefs.SetInt(nextLvlExpKey, GlobalVariables.nextLevelExp);
        }
    }
}
