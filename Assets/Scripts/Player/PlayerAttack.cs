using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
	[SerializeField] private GameObject _projectile;
	[SerializeField] private Transform _shootPoint;
	[SerializeField] private float _maxCooldown;
	private bool _pressing;
	private float _cooldown;

	private void Start()
	{
		_cooldown = _maxCooldown;
	}
	private void Update()
	{
		_cooldown -= Time.deltaTime;
		if (_cooldown <= 0)
		{
			_cooldown = _maxCooldown;
			if (_pressing)
			{
				Attack();
			}
			else return;
			
		}
	}

	public void Attack()
	{
		Debug.Log("Attack");
		Instantiate(_projectile, _shootPoint.position, _projectile.transform.rotation);
	}
	public void PressingDown()
	{
		_pressing = true;
	}

	public void PickedUpButton()
	{
		_pressing = false;
	}
}
