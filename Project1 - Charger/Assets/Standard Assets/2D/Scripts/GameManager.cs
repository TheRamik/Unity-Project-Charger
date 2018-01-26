using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager: MonoBehaviour {

    public PlatformerCharacter2D thePlayer;
    private Vector3 playerStarterPoint;

	// Use this for initialization
	void Start () {
        playerStarterPoint = thePlayer.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RestartGame()
    {

    }
}
