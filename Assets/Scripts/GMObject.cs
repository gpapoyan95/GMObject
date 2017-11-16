using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class GMObject : MonoBehaviour {

    private int gameOpenCount;
	
    /*
     * Use log(*object*) instead of Debug.Log(*object*)
     */
	
    protected void log(object context) {
        Debug.Log(context);
    }
	
    /*
     * Return game open count
     */

    public int getGameOpenCount() {
        return PlayerPrefs.GetInt("GAME_OPEN_COUNT", gameOpenCount);
    }
	
       
}