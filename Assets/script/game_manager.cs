using UnityEngine;
using System.Collections;

public class game_manager : MonoBehaviour {

    public static int userPoint;
    public GameObject gui;

	// Use this for initialization
	void Start () {
        Time.timeScale = 1.0f;
        userPoint = 0;
        gui.SetActive(false);
	}

    public void showGUI ()
    {
        gui.SetActive(true);
    }
	// Update is called once per frame
	void Update () {
	    
	}
}
