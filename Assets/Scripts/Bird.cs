using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

	private bool isDead = false;
	private Rigidbody2D rb2d;
	public float upForce;
	private Animator anim;

	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator> ();
	}

	void Update () {
		if (isDead == false)
		{
			if (Input.GetMouseButton(0))
			{
				anim.SetTrigger("Flap");
				rb2d.velocity = Vector2.zero;
				rb2d.AddForce(new Vector2(0, upForce));
			}
		}
	}

	void OnCollisionEnter2D()
	{
		rb2d.velocity = Vector2.zero;
		isDead = true;
		anim.SetTrigger ("Die");
		GameControl.instance.BirdDied ();
	}
}