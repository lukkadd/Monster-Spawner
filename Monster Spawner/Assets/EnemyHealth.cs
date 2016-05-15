using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	public int enemyHealth;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (enemyHealth <= 0) {
			Destroy (this.gameObject);
		}
	}
}
