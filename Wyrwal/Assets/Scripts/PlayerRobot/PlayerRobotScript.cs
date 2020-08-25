using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRobotScript : MonoBehaviour
{
    private bool facingRight = true;
    private bool doubleJump = false;
    private int numberOfJumps = 0;
	private float playerRobotWalkSpeed = 4.0f;
	private float playerRobotSpeed = 0.0f;
	private float playerRobotJumpForce = 450.0f;

	private void Start()
	{
		playerRobotSpeed = playerRobotWalkSpeed;
	}

	private void Update()
    {
		if (Input.GetKeyDown(KeyCode.A) && facingRight)
		{
			facingRight = false;
			PlayerRobotTurn();
		}
		if (Input.GetKeyDown(KeyCode.D) && !facingRight)
		{
			facingRight = true;
			PlayerRobotTurn();
		}

		PlayerRobotJump();
		PlayerRobotMoveRight();
		PlayerRobotMoveLeft();
	}

	private void PlayerRobotTurn()
	{
		transform.Rotate(Vector3.up * 180);

		PlayerRobotFreezeOnWall();
	}

	private void PlayerRobotJump()
	{
		if ((Input.GetKeyDown(KeyCode.Space)) && !doubleJump)
		{
			PlayerRobotFreezeOnWall();

			numberOfJumps++;
			if (numberOfJumps > 1)
			{
				doubleJump = true;
				numberOfJumps = 0;
			}
			GetComponent<Rigidbody2D>().AddForce(transform.up * playerRobotJumpForce);
		}
	}

	private void PlayerRobotMoveRight()
	{
		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(transform.right * playerRobotSpeed * Time.deltaTime);
		}
	}

	private void PlayerRobotMoveLeft()
	{
		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(-transform.right * playerRobotSpeed * Time.deltaTime);
		}
	}

	private void PlayerRobotFreezeOnWall()
	{
		playerRobotSpeed = playerRobotWalkSpeed;
		GetComponent<Rigidbody2D>().gravityScale = 1.0f;
	}

	private void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.CompareTag("Ground"))
		{
			doubleJump = false;
		}

		if (col.gameObject.CompareTag("Wall"))
		{
			doubleJump = false;
			numberOfJumps = 0;
			playerRobotSpeed = 0;
			GetComponent<Rigidbody2D>().gravityScale = 0.0f;
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		}
	}
}
