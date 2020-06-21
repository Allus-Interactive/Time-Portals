using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPlayerStats : MonoBehaviour
{
    public Text playerLevel;
    public Text currentExp;
    public Text nextLevelExp;

    string levelKey = "PlayerLevel";
    string expKey = "CurrentExp";
    string nextLvlExpKey = "NextLevelExp";

    void Update()
    {
        if (PlayerPrefs.HasKey(levelKey) && PlayerPrefs.HasKey(expKey) && PlayerPrefs.HasKey(nextLvlExpKey))
        {
            playerLevel.text = "Player Level: " + PlayerPrefs.GetInt(levelKey).ToString();
            currentExp.text = "Current Exp: " + PlayerPrefs.GetInt(expKey).ToString();
            nextLevelExp.text = "Exp to next level: " + PlayerPrefs.GetInt(nextLvlExpKey).ToString();
        }
        /*else
        {
            playerLevel.text = "Player Level: 1";
            currentExp.text = "Current Exp: 0";
            nextLevelExp.text = "Exp to next level: 100";
        }*/
    }
}
