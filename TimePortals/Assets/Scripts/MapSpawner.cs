using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSpawner : Singleton<MapSpawner>
{
    [SerializeField] private MapPortal[] availablePortals;
    [SerializeField] private Player player;
    [SerializeField] private float waitTime = 180.0f;
    [SerializeField] private int startingPortals = 5;
    [SerializeField] private float minRange = 5.0f;
    [SerializeField] private float maxRange = 50.0f;

    private List<MapPortal> livePortals = new List<MapPortal>();
    private MapPortal selectedPortal;

    public List<MapPortal> LivePortals
    {
        get { return livePortals; }
    }

    public MapPortal SelectedPortal
    {
        get { return selectedPortal; }
    }

    private void Awake()
    {
        // Assert.isNotNull(availablePortals);
        // Assert.isNotNull(player);
    }

    void Start()
    {
        for(int i = 0; i < startingPortals; i++)
        {
            InstantiatePortal();
        }

        StartCoroutine(GeneratePortals());
    }

    public void PortalWasSelected(MapPortal portal)
    {
        selectedPortal = portal;
    }

    private IEnumerator GeneratePortals()
    {
        while (true)
        {
            InstantiatePortal();
            yield return new WaitForSeconds(waitTime);
        }
    }

    private void InstantiatePortal()
    {
        int index = Random.Range(0, 1/*availablePortals.length*/);
        float x = player.transform.position.x + GenerateRange();
        float z = player.transform.position.z + GenerateRange();
        float y = player.transform.position.y;
        livePortals.Add(Instantiate(availablePortals[index], new Vector3(x, y, z), Quaternion.identity));
    }

    private float GenerateRange()
    {
        float randomNum = Random.Range(minRange, maxRange);
        bool isPositive = Random.Range(0, 10) < 5;
        return randomNum * (isPositive ? 1 : -1);
    }
}
