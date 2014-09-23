using UnityEngine;
using System.Collections;

public class laser_manager : MonoBehaviour {

    private Vector3 player_position;
	// Use this for initialization
	void Start () {
        player_position = GameObject.Find("Player").transform.position;
        transform.position = new Vector3(player_position.x, player_position.y + 0.30f, player_position.z);
        rigidbody2D.AddForce(new Vector2(0,200));

	}

    void Update()
    {
        if (transform.position.y > 6)
        {
            Destroy(gameObject);
        }
    }
}
