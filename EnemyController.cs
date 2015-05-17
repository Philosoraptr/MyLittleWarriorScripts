using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public float hitPoints = 100f;

	void Start () 
	{
	
	}

	void Update () 
	{
	
	}

	public void TakeDamage(float damage)
	{
		hitPoints -= damage;
	}
}
