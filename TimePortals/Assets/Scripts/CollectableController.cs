using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectableController : MonoBehaviour
{
    private AudioSource collectableSFX;

    string expKey = "CurrentExp";

    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                if (raycastHit.collider.CompareTag("Collectable"))
                {
                    // set sound effect and play it
                    collectableSFX = GetComponent<AudioSource>();
                    collectableSFX.Play();
                    // set the collectable inactive
                    gameObject.SetActive(false);
                    // use collectable name to set bool for collectable
                    SetCollectableBool(gameObject.name);
                    // add exp to current exp and save to PlayerPrefs
                    GlobalVariables.currentExp += 50;
                    PlayerPrefs.SetInt(expKey, GlobalVariables.currentExp);
                    // return to map scene
                    SceneManager.LoadScene(1);
                }
            }
        }
    }

    public void SetCollectableBool(string collectableName)
    {
        if (collectableName == "TemplarShield")
        {
            GlobalVariables.templarShieldCollected = true;
        }

        if (collectableName == "TemplarSword")
        {
            GlobalVariables.templarSwordCollected = true;
        }

        if (collectableName == "PirateCutlass")
        {
            GlobalVariables.pirateCutlassCollected = true;
        }

        if (collectableName == "CoinStash")
        {
            GlobalVariables.pirateCoinCollected = true;
        }

        if (collectableName == "GreekSword")
        {
            GlobalVariables.greekSwordCollected = true;
        }

        if (collectableName == "GreekStatuette")
        {
            GlobalVariables.greekStatuetteCollected = true;
        }
    }
}
