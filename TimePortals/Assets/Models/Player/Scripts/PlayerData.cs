using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerData {

	private int xp;
	private int requiredXp;
	private int levelBase;
	private int level;
	// private List<DroidData> droids;

	public int Xp { get { return xp; } }
	public int RequiredXp { get { return requiredXp; } }
	public int LevelBase { get { return levelBase; } }
	public int Level { get { return level; } }
	// public List<DroidData> Droids { get { return droids; } }

	public PlayerData(Player player) {

		xp = player.XP;
		requiredXp = player.RequiredXP;
		levelBase = player.LevelBase;
		level = player.Level;
		/*foreach(GameObject droidObject in player.Droids) {

			Droid droid = droidObject.GetComponent<Droid>();
			if(droid != null) {

				DroidData data = new DroidData(droid);
				droids.Add(data);

			}

		}*/

	}
}
