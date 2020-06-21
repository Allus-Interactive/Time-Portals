using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalVariables
{
    // Collectable booleans
    public static bool templarShieldCollected = false;
    public static bool templarSwordCollected = false;
    public static bool greekStatuetteCollected = false;
    public static bool greekSwordCollected = false;
    public static bool pirateCoinCollected = false;
    public static bool pirateCutlassCollected = false;

    // Player Stats
    public static int playerLevel;
    public static int currentExp;
    public static int nextLevelExp;

    // Level Exp
    public static float level1 = 100;
    public static float level2 = 200;
    public static float level3 = 400;
    public static float level4 = 800;
    public static float level5 = 1600;
    public static float level6 = 3200;
    public static float level7 = 6400;
    public static float level8 = 12800;
    public static float level9 = 25600;
    public static float level10 = 51200;
}
