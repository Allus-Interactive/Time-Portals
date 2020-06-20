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

    public void Awake()
    {
        if (PlayerPrefs.HasKey(levelKey) && PlayerPrefs.HasKey(expKey))
        {
            LevelText.text = PlayerPrefs.GetFloat(levelKey).ToString();
            ExpText.text = PlayerPrefs.GetFloat(expKey).ToString();
        }
        else
        {
            LevelText.text = GlobalVariables.playerLevel.ToString();
            ExpText.text = GlobalVariables.currentExp.ToString() + " / " + 100;
        }
    }

    public void Update()
    {
        var nextLevelExp = GlobalVariables.level1.ToString();

        if (GlobalVariables.playerLevel == 2)
        {
            nextLevelExp = GlobalVariables.level2.ToString();
        }
        else if (GlobalVariables.playerLevel == 3)
        {
            nextLevelExp = GlobalVariables.level4.ToString();
        }
        else if (GlobalVariables.playerLevel == 4)
        {
            nextLevelExp = GlobalVariables.level5.ToString();
        }
        else if (GlobalVariables.playerLevel == 5)
        {
            nextLevelExp = GlobalVariables.level6.ToString();
        }
        else if (GlobalVariables.playerLevel == 6)
        {
            nextLevelExp = GlobalVariables.level7.ToString();
        }
        else if (GlobalVariables.playerLevel == 7)
        {
            nextLevelExp = GlobalVariables.level8.ToString();
        }
        else if (GlobalVariables.playerLevel == 8)
        {
            nextLevelExp = GlobalVariables.level9.ToString();
        }
        else if (GlobalVariables.playerLevel == 9)
        {
            nextLevelExp = GlobalVariables.level10.ToString();
        }
        else if (GlobalVariables.playerLevel == 10)
        {
            nextLevelExp = "";
        }


        if (PlayerPrefs.HasKey(levelKey) && PlayerPrefs.HasKey(expKey))
        {
            LevelText.text = PlayerPrefs.GetFloat(levelKey).ToString();
            ExpText.text = PlayerPrefs.GetFloat(expKey).ToString() + " / " + nextLevelExp;
        }
            

        // TODO: this has the potential to get messy, need to make this better
        if (GlobalVariables.playerLevel == 1 && GlobalVariables.currentExp >= 100)
        {
            GlobalVariables.playerLevel = 2;
            GlobalVariables.currentExp = 0;
        }

        if (GlobalVariables.playerLevel == 2 && GlobalVariables.currentExp >= 200)
        {
            GlobalVariables.playerLevel = 3;
            GlobalVariables.currentExp = 0;
        }

        if (GlobalVariables.playerLevel == 3 && GlobalVariables.currentExp >= 400)
        {
            GlobalVariables.playerLevel = 4;
            GlobalVariables.currentExp = 0;
        }

        if (GlobalVariables.playerLevel == 4 && GlobalVariables.currentExp >= 800)
        {
            GlobalVariables.playerLevel = 5;
            GlobalVariables.currentExp = 0;
        }

        if (GlobalVariables.playerLevel == 5 && GlobalVariables.currentExp >= 1600)
        {
            GlobalVariables.playerLevel = 6;
            GlobalVariables.currentExp = 0;
        }

        if (GlobalVariables.playerLevel == 6 && GlobalVariables.currentExp >= 3200)
        {
            GlobalVariables.playerLevel = 7;
            GlobalVariables.currentExp = 0;
        }

        if (GlobalVariables.playerLevel == 7 && GlobalVariables.currentExp >= 6400)
        {
            GlobalVariables.playerLevel = 8;
            GlobalVariables.currentExp = 0;
        }

        if (GlobalVariables.playerLevel == 8 && GlobalVariables.currentExp >= 12800)
        {
            GlobalVariables.playerLevel = 9;
            GlobalVariables.currentExp = 0;
        }

        if (GlobalVariables.playerLevel == 9 && GlobalVariables.currentExp >= 25600)
        {
            GlobalVariables.playerLevel = 10;
            GlobalVariables.currentExp = 0;
        }

        if (GlobalVariables.playerLevel == 10 && GlobalVariables.currentExp >= 51200)
        {
            GlobalVariables.playerLevel = 10;
            GlobalVariables.currentExp = 0;
            ExpText.text = "Max";
        }

        // Set PlayerPrefs
        PlayerPrefs.SetFloat(levelKey, GlobalVariables.playerLevel);
        PlayerPrefs.SetFloat(expKey, GlobalVariables.currentExp);
    }
}
