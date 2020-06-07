using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableManager : MonoBehaviour
{
    public Image TemplarShield;
    public Image TemplarSword;

    public Sprite TemplarShieldUnlocked;
    public Sprite TemplarSwordUnlocked;
    
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

        // TODO: add in if statements for other collectables
    }
}
