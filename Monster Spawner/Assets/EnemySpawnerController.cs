using UnityEngine;
using System.Collections;

public class EnemySpawnerController : MonoBehaviour {

	public GameObject enemy;
	public int health;
	public int maxEnemies;
	public float spawnDelay;
	private int spawnCount = 0;

	void Start () {
		
	}

	void Update () {
	
	}

	void OnTriggerStay(Collider other){
		if(other.gameObject.CompareTag("Player") && spawnCount < maxEnemies){
			Instantiate(enemy,transform.position,transform.rotation);
			spawnCount++;
		}
	}
}
