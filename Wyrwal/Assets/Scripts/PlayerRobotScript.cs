using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRobotScript : MonoBehaviour
{
    private bool facingRight = true;
    private bool doubleJump = false;
    private int numberOfJumps = 0;

    private void Update()
    {
		if ((Input.GetKeyDown(KeyCode.A)) && facingRight)
		{
			facingRight = false;
			PlayerRobotTurn();
		}
		if ((Input.GetKeyDown(KeyCode.D)) && !facingRight)
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
	}

	private void PlayerRobotJump()
	{
		if ((Input.GetKeyDown(KeyCode.Space)) && !doubleJump)
		{
			numberOfJumps++;
			if (numberOfJumps == 1)
			{
				doubleJump = true;
			}

			if (numberOfJumps > 1)
			{
				numberOfJumps = 0;
			}
			GetComponent<Rigidbody2D>().AddForce(transform.up * 400);
		}
	}

	private void PlayerRobotMoveRight()
	{
		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(transform.right * 4 * Time.deltaTime);
		}
	}

	private void PlayerRobotMoveLeft()
	{
		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(-transform.right * 4 * Time.deltaTime);
		}
	}

	private void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.CompareTag("Ground"))
		{
			doubleJump = false;
		}
	}
}
