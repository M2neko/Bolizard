using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BoyMove : MonoBehaviour
{
	public float SpeedX = 5.0f;
	public float SpeedY = 3.0f;

	private void Start()
	{

	}

	private void Update()
	{
		var rigidBody = gameObject.GetComponent<Rigidbody2D>();

		// ------------------- LeftRight ---------------------------------------
		if (Input.GetAxisRaw("Horizontal") > 0.01)
		{
			if (rigidBody != null)
			{
				rigidBody.velocity = new Vector2(this.SpeedX, rigidBody.velocity.y);
				gameObject.GetComponent<SpriteRenderer>().flipX = false;
			}
		}

		else if (Input.GetAxisRaw("Horizontal") < -0.01)
		{
			if (rigidBody != null)
			{
				rigidBody.velocity = new Vector2(-this.SpeedX, rigidBody.velocity.y);
				gameObject.GetComponent<SpriteRenderer>().flipX = true;
			}
		}
		else
		{
			if (rigidBody != null)
			{
				rigidBody.velocity = new Vector2(0.0f, rigidBody.velocity.y);
			}
		}

		if (Input.GetAxisRaw("Vertical") > 0.01)
		{
			if (rigidBody != null)
			{
				rigidBody.velocity = new Vector2(rigidBody.velocity.x, this.SpeedY);
			}
		}
		else if (Input.GetAxisRaw("Vertical") < -0.01)
		{
			if (rigidBody != null)
			{
				rigidBody.velocity = new Vector2(rigidBody.velocity.x, -this.SpeedY);
			}
		}
		else
		{
			if (rigidBody != null)
			{
				rigidBody.velocity = new Vector2(rigidBody.velocity.x, 0.0f);
			}
		}

		// ---------------------------------------------------------------------

		gameObject.GetComponent<Animator>().SetFloat("Velocity", Mathf.Abs(rigidBody.velocity.x / 5.0f));
		if(gameObject.GetComponent<Animator>().GetFloat("Velocity") <= 0.01f)
			gameObject.GetComponent<Animator>().SetFloat("Velocity", Mathf.Abs(rigidBody.velocity.y / 5.0f));

		if (gameObject.GetComponent<Animator>().GetFloat("Velocity") > 0.01f)
        {
            if (!gameObject.GetComponent<AudioSource>().isPlaying)
                gameObject.GetComponent<AudioSource>().Play();
        }
        else
        {
            gameObject.GetComponent<AudioSource>().Stop();
        }
		

	}
}
