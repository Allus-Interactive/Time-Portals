using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldSceneManager : RelicHuntersSceneManager
{
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    public override void playerTapped(GameObject player)
    {

    }


    public override void portalTapped(GameObject portal)
    {
        // SceneManager.LoadScene(RelicHunterConstants.SCENE_BASIC_PORTAL, LoadSceneMode.Additive);
        SceneManager.LoadScene(4);
    }
}
