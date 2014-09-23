using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

    private float hAxes;
    private float sensibility = 15f;
    private float english;

    public GameObject laser;

	// Update is called once per frame
	void Update () {

        // this handles the movement of the mouse
        hAxes = Input.GetAxis("Mouse X") * sensibility;

        transform.Translate(new Vector3(hAxes * Time.deltaTime, 0, 0));
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -5.9f, 5.9f),
        transform.position.y, transform.position.z);

        // this handle the shooting
        if (Input.GetMouseButtonDown(0)) {
            Instantiate(laser);
        }
	}
}
