using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] private float _jumpForce;
	[SerializeField] private Rigidbody2D _rb2d;

	public void Jump()
	{
		if (_rb2d.velocity.y != 0) return;
		_rb2d.AddForce(new Vector2(transform.position.x, _jumpForce), ForceMode2D.Impulse);
	}

}
