using UnityEngine;
using System.Collections;

public class EnemySpawnerController : MonoBehaviour {

	public GameObject enemy;
	public int health;
	public int maxEnemies;
	public float spawnDelay;
	private float nextSpawn;

	void Start () {
	}

	void Update () {
		die ();
	}

	 void OnTriggerStay (Collider other){
		if(other.gameObject.CompareTag("Player") && transform.childCount < maxEnemies && Time.time > nextSpawn ){
			SpawnEnemy ();
			nextSpawn = Time.time + spawnDelay;
		}
	}

	void die(){
		if(health<=0){
			Destroy(this.gameObject);
		}
	}

	void SpawnEnemy(){
		GameObject flyingEnemy = Instantiate(enemy,transform.position,transform.rotation) as GameObject;
		flyingEnemy.transform.parent = transform;
	}
}
