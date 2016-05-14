using UnityEngine;
using System.Collections;

public class EnemySpawnerController : MonoBehaviour {

	public GameObject enemy;
	public int health;
	public int maxEnemies;
	public float spawnDelay;
	private float nextSpawn;
	public int spawnCount = 0;

	void Start () {
	}

	void Update () {
		die ();
	}

	 void OnTriggerStay (Collider other){
		if(other.gameObject.CompareTag("Player") && spawnCount < maxEnemies && Time.time > nextSpawn ){
			GameObject flyingEnemy = (GameObject)Instantiate(enemy,transform.position,transform.rotation);
			nextSpawn = Time.time + spawnDelay;
			spawnCount++;
		}
	}

	void die(){
		if(health<=0){
			Destroy(this.gameObject);
		}
	}
}
