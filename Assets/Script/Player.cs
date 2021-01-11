using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public GameObject ResetUI;
	private bool isGameover = false;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		float speed = 5;
		float x = Input.GetAxisRaw("Horizontal");
		this.transform.position -= Vector3.left * x * speed * Time.deltaTime;

		var ball = GameObject.Find("Ball");
		if ((ball.transform.position.y < -25.0) && !isGameover)
		{
			isGameover = true;
			Instantiate(ResetUI);
		}
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "Ball")
		{
			Debug.Log("OnCollisionEnter");
			Vector3 v = other.rigidbody.velocity;
			Vector3 ballv = Vector3.Normalize(new Vector3(v.x, 1, 1));
			other.rigidbody.velocity = ballv * 50;
		}
	}
}