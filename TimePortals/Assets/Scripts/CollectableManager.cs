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

    void Update()
    {
        if (GlobalVariables.templarShieldCollected)
        {
            TemplarShield.sprite = TemplarShieldUnlocked;
        }

        if (GlobalVariables.templarSwordCollected)
        {
            TemplarSword.sprite = TemplarSwordUnlocked;
        }

        if (GlobalVariables.pirateCutlassCollected)
        {
            PirateCutlass.sprite = PirateCutlassUnlocked;
        }

        if (GlobalVariables.pirateCoinCollected)
        {
            PirateCoin.sprite = PirateCoinUnlocked;
        }

        if (GlobalVariables.greekSwordCollected)
        {
            GreekSword.sprite = GreekSwordUnlocked;
        }

        if (GlobalVariables.greekStatuetteCollected)
        {
            GreekStatuette.sprite = GreekStatuetteUnlocked;
        }
    }
}
