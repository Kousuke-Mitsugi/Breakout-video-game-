using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.UI;

public class Block : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnCollisionEnter(Collision other)
	{
		GameObject textui = GameObject.Find("Message");
		int score = int.Parse(textui.GetComponent<Text>().text);
		score += 100;
		textui.GetComponent<Text>().text = score.ToString();


		Destroy(this.gameObject);
	}
}