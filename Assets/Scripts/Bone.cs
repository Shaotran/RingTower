﻿/* Ethan Shaotran 2017
 * in Collaboration with 
 * Purifi Games & Shaotran.com */

using UnityEngine;
using System.Collections;

public class Bone : MonoBehaviour {

	public GameObject BoneController;

	// Update is called once per frame
	void FixedUpdate()
	{
		transform.position = BoneController.transform.position;
		transform.rotation = BoneController.transform.rotation;
	}
}
