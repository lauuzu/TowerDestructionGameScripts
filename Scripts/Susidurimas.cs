﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Susidurimas : MonoBehaviour {

	public float StumimoGalia = 5f;

	void Kolaideris(ControllerColliderHit hit)
	{
		Rigidbody body = hit.collider.attachedRigidbody;
		if (body == null || body.isKinematic)
			return;
		if (hit.moveDirection.y < -0.3f)
			return;

		Vector3 StumimoKryptis = new Vector3 (hit.moveDirection.x, 0, hit.moveDirection.z);
		body.velocity = StumimoKryptis * StumimoGalia;
	}

}
