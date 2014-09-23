using UnityEngine;
using System.Collections;

public class spawn_enemy : MonoBehaviour {

    public GameObject[] ufos = new GameObject[4];
    public static int howManyEnemy;
    private static int maxEnemy;
    private float spawnEnemyRate = 2.0f;

    private int rnd_ufo;
	// Use this for initialization
	void Start () {
        howManyEnemy = 0;
        maxEnemy = 3;
        InvokeRepeating("spawnUfos", 1.0f, spawnEnemyRate);
        InvokeRepeating("increaseDifficulty", 1.0f, 1f);
	}

    private void spawnUfos()
    {
        if (howManyEnemy >= maxEnemy) return;
        // choose a random enemy
        rnd_ufo = Random.Range(0, 3);
        //now spawn it
        Instantiate(ufos[rnd_ufo]);
        ++howManyEnemy;
    }

    private void increaseDifficulty()
    {
        InvokeRepeating("spawnUfos", 1.0f, 10f);
        //maxEnemy += 2;
    }
}
