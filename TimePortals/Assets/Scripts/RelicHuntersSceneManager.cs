using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RelicHuntersSceneManager : MonoBehaviour
{
    public abstract void playerTapped(GameObject player);
    public abstract void portalTapped(GameObject portal);
}
