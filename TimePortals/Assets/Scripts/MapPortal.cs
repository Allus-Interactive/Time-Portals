using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPortal : MonoBehaviour
{
    [SerializeField] private float spawnRate = 0.01f;

    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    public float SpawnRate
    {
        get { return spawnRate; }
    }

    private void OnMouseDown()
    {
        RelicHuntersSceneManager[] managers = FindObjectsOfType<RelicHuntersSceneManager>();
        foreach (RelicHuntersSceneManager relicHuntersSceneManager in managers)
        {
            if (relicHuntersSceneManager.gameObject.activeSelf)
            {
                relicHuntersSceneManager.portalTapped(this.gameObject);
                Destroy(this.gameObject);
            }
        }
    }
}
