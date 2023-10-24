using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	[SerializeField] private float _speed;
	[SerializeField] private float _damage;
	Rigidbody2D _rb2d;


	private void Start()
	{
		_rb2d = GetComponent<Rigidbody2D>();
	}
	//private void FixedUpdate()
	//{
	//	_rb2d.velocity += (new Vector2(_rb2d.velocity.x * _speed * Time.fixedDeltaTime, transform.position.y)* Vector2.right);
	//}
	private void Update()
	{
		_rb2d.AddForce(Vector2.right*_speed*Time.deltaTime);
	}
}
