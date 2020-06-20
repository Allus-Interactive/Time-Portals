using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableManager : MonoBehaviour
{
    public Image TemplarShield;
    public Image TemplarSword;
    public Image PirateCutlass;
    public Image PirateCoin;
    public Image GreekSword;
    public Image GreekStatuette;

    public Sprite TemplarShieldUnlocked;
    public Sprite TemplarSwordUnlocked;
    public Sprite PirateCutlassUnlocked;
    public Sprite PirateCoinUnlocked;
    public Sprite GreekSwordUnlocked;
    public Sprite GreekStatuetteUnlocked;

    private string templarShieldKey = "TemplarShield";
    private string templarSwordKey = "TemplarSword";
    private string pirateCutlassKey = "PirateCutlass";
    private string pirateCoinKey = "PirateCoin";
    private string greekStatuetteKey = "GreekStatuette";
    private string greekSwordKey = "GreekSword";

    void Awake()
    {
        if (PlayerPrefs.HasKey(templarShieldKey))
        {
            GlobalVariables.templarShieldCollected = (PlayerPrefs.GetInt(templarShieldKey) != 0);
        }

        if (PlayerPrefs.HasKey(templarSwordKey))
        {
            GlobalVariables.templarSwordCollected = (PlayerPrefs.GetInt(templarSwordKey) != 0);
        }

        if (PlayerPrefs.HasKey(pirateCutlassKey))
        {
            GlobalVariables.pirateCutlassCollected = (PlayerPrefs.GetInt(pirateCutlassKey) != 0);
        }

        if (PlayerPrefs.HasKey(pirateCoinKey))
        {
            GlobalVariables.pirateCoinCollected = (PlayerPrefs.GetInt(pirateCoinKey) != 0);
        }

        if (PlayerPrefs.HasKey(greekSwordKey))
        {
            GlobalVariables.greekSwordCollected = (PlayerPrefs.GetInt(greekSwordKey) != 0);
        }

        if (PlayerPrefs.HasKey(greekStatuetteKey))
        {
            GlobalVariables.greekStatuetteCollected = (PlayerPrefs.GetInt(greekStatuetteKey) != 0);
        }
    }

    void Update()
    {
        if (GlobalVariables.templarShieldCollected)
        {
            TemplarShield.sprite = TemplarShieldUnlocked;
            PlayerPrefs.SetInt(templarShieldKey, 1);

        }

        if (GlobalVariables.templarSwordCollected)
        {
            TemplarSword.sprite = TemplarSwordUnlocked;
            PlayerPrefs.SetInt(templarSwordKey, 1);
        }

        if (GlobalVariables.pirateCutlassCollected)
        {
            PirateCutlass.sprite = PirateCutlassUnlocked;
            PlayerPrefs.SetInt(pirateCutlassKey, 1);
        }

        if (GlobalVariables.pirateCoinCollected)
        {
            PirateCoin.sprite = PirateCoinUnlocked;
            PlayerPrefs.SetInt(pirateCoinKey, 1);
        }

        if (GlobalVariables.greekSwordCollected)
        {
            GreekSword.sprite = GreekSwordUnlocked;
            PlayerPrefs.SetInt(greekSwordKey, 1);
        }

        if (GlobalVariables.greekStatuetteCollected)
        {
            GreekStatuette.sprite = GreekStatuetteUnlocked;
            PlayerPrefs.SetInt(greekStatuetteKey, 1);
        }
    }
}
