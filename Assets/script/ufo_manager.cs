using UnityEngine;
using System.Collections;

public class ufo_manager : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3(Random.Range(-5.9f, 5.9f), 5.5f, 0);
        rigidbody2D.AddForce(new Vector2(Random.Range(-10, -100), 
            Random.Range(-50, -100)));
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -5.9)
        {
            rigidbody2D.Sleep();
            rigidbody2D.WakeUp();

            rigidbody2D.AddForce(new Vector2(Random.Range(10, 100), 
                Random.Range(-50, -100)));
        }
        else if (transform.position.x > 5.9)
        {
            rigidbody2D.Sleep();
            rigidbody2D.WakeUp();

            rigidbody2D.AddForce(new Vector2(Random.Range(10, 100),
                Random.Range(50, 100)));
        }
        else if (transform.position.y < -2.7)
        {
            GameObject.Find("_GM").GetComponent<game_manager>().showGUI();
            Time.timeScale = 0;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "lazor")
        {
            game_manager.userPoint += 10;
            --spawn_enemy.howManyEnemy;
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
        
    }
}
