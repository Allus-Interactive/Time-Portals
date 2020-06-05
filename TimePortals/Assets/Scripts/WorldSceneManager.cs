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
        // Random.Range(min, max): choses random int from between min and max-1
        var randomInt = Random.Range(4, 7);
        SceneManager.LoadScene(4);
    }
}
