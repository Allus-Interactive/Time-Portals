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

        var playerLvl = PlayerPrefs.GetInt(levelKey, 0);

        if (playerLvl != 0)
        {
            playerLevel.text = "Player Level: " + PlayerPrefs.GetInt(levelKey).ToString();
            currentExp.text = "Current Exp: " + PlayerPrefs.GetInt(expKey).ToString();
            nextLevelExp.text = "Exp to next level: " + PlayerPrefs.GetInt(nextLvlExpKey).ToString();
        }
        else
        {
            PlayerPrefs.SetInt(levelKey, 1);
            PlayerPrefs.SetInt(expKey, 0);
            PlayerPrefs.SetInt(nextLvlExpKey, 100);

            playerLevel.text = "Player Level: " + PlayerPrefs.GetInt(levelKey).ToString();
            currentExp.text = "Current Exp: " + PlayerPrefs.GetInt(expKey).ToString();
            nextLevelExp.text = "Exp to next level: " + PlayerPrefs.GetInt(nextLvlExpKey).ToString();
        }
    }
}
