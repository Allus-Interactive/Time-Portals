using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField] private int xp = 0;
    [SerializeField] private int requiredXP = 100;
    [SerializeField] private int levelBase = 100;
    [SerializeField] private List<GameObject> droids = new List<GameObject>();
    private int level = 1;

    private string path;

    public int XP { get { return xp; } }
    public int RequiredXP { get { return requiredXP; } }
    public int LevelBase { get { return levelBase; } }
    public List<GameObject> Droids { get { return droids; } }

    public int Level { get { return level; } }

	// Use this for initialization
	void Start () {
        path = Application.persistentDataPath + "/player.dat";
        load();
	}
	
	public void addXP(int xp)
    {
        this.xp += Mathf.Max(0, xp);

        if(this.xp >= this.requiredXP) {
            this.xp -= this.requiredXP;
            this.level++;
        }

        save();
    }

    public void addDroid(GameObject droid)
    {
        this.droids.Add(droid);
        save();
    }

    private void initLevelData()
    {
        level = (xp / levelBase) + 1;
        requiredXP = levelBase * level;

    }

    private void save() {

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(path);
        PlayerData data = new PlayerData(this);
        bf.Serialize(file, data);
        file.Close();

    }

    private void load() {

        if(File.Exists(path)) {

            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(path, FileMode.Open);
            PlayerData data = (PlayerData) bf.Deserialize(file);
            file.Close();

            xp = data.Xp;
            requiredXP = data.RequiredXp;
            levelBase = data.LevelBase;
            level = data.Level;

            /*foreach(DroidData droidData in data.Droids) {
                Droid droid = new Droid();
                droid.loadFromDroidData(droidData);
                addDroid(droid.gameObject);
            }*/
    
        } else {
            initLevelData();
        }

    }

}
