using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieEnemy : MonoBehaviour
{
	public float speed = -0.01f;
	//Reference to waypoints
	public List<Transform> points;
	//The int value for next point index
	public int nextID;
	//The value of that applies to ID for changing
	int idChangeValue = 1;


	private void Reset ()
	{
		//Make box collider trigger
		GetComponent<BoxCollider2D>().isTrigger = true;
		
		//Create Root object
		GameObject root = new GameObject(name + "_Root");
		//Reset Position of Root to enemy object
		root.transform.position = transform.position;
		//Set enemy object as zombie of root
		transform.SetParent(transform);
		//Create Waypoints object
		GameObject waypoints = new GameObject("Waypoints");
		//Reset waypoints position to root 
		//Make waypoints object zombie of root
		waypoints.transform.SetParent(root.transform);
		waypoints.transform.position = root.transform.position;
		//Create two points (gameobject) and reset their position to waypoint objects
		//Make the points zombie of waypoint object
		GameObject p1 = new GameObject("Point1");p1.transform.SetParent(waypoints.transform);p1.transform.position = root.transform.position;
		GameObject p2 = new GameObject("Point1");p2.transform.SetParent(waypoints.transform);p2.transform.position = root.transform.position;

		//Init points list then add the points to it
		points = new List<Transform>();
		points.Add(p1.transform);
		points.Add(p2.transform);
	}

	void Update()
	{
		// need some logic here for movement
		transform.Translate(speed,0,0);
	}

}
