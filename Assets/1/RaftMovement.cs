using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaftMovement : MonoBehaviour
{
	public float Speed = 3.0f;
	public int rotationspeed = 150;
	private Vector3 startPos;
	private Vector3 endPos;

	private void Update()
	{
		Vector3 dir = (endPos - transform.position).normalized;
		transform.position = transform.position + dir * Time.deltaTime * Speed;
		transform.Rotate(0,Time.deltaTime * rotationspeed,0);
		
		// if raft is close to end point, reset
		if (Vector3.Distance(endPos, transform.position) <= (dir * Time.deltaTime * Speed).magnitude)
		{
			ResetRaft();
		}
	}

	private void ResetRaft()
	{
		startPos = new Vector3(Random.Range(-15f, 15f), 0.0f, -15f);
		endPos = startPos;
		endPos.x = Random.Range(-15f, 15f);
		endPos.z *= -1.0f;
		transform.position = startPos;
		transform.rotation = Quaternion.identity;

	}
	private void Start()
	{
		ResetRaft();
	}

	private void OnTriggerEnter(Collider other)
	{
		//float x, y, radius = 0.5000001f;
		float currentAngle = transform.rotation.eulerAngles.y;
		Debug.Log(currentAngle);

		/////////////// worldspace postion

		/*
		currentAngle += Time.deltaTime * ((Mathf.PI * 2));
		x = radius * Mathf.Cos(currentAngle);
		y = radius * Mathf.Sin(currentAngle);
		transform.position = new Vector3(x, y, transform.position.z);

		 Debug.Log(currentAngle);

		switch (direction)
		{
		case "left":
		  break;
		}*/

	}

}
