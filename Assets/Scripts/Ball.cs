using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{

	private Paddle paddle;
	private Vector3 paddleToBallVector;
	private bool hasStarted = false;
	
	// Use this for initialization
	void Start ()
	{
		paddle = GameObject.FindObjectOfType<Paddle> ();
		paddleToBallVector = this.transform.position - paddle.transform.position;
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!hasStarted) {
			//lock 
			this.transform.position = paddle.transform.position + paddleToBallVector;
			
			if (Input.GetMouseButtonDown (0)) {
				print ("Mouse clicked, launch ball");
				hasStarted = true;
				this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (2f, 10f);
				
			}
		} else {
			
		}
	}
	
	void OnCollisionEnter2D (Collision2D collision)
	{
		Vector2 tweak = new Vector2(Random.Range (0f, 0.5f), Random.Range(0f,0.5f));
		if (hasStarted) {
			this.GetComponent<AudioSource>().Play ();
			this.GetComponent<Rigidbody2D> ().velocity += tweak;
		}
	}
	
}
