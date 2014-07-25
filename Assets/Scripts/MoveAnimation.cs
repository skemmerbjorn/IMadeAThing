﻿using UnityEngine;
using System.Collections;

public class MoveAnimation : MonoBehaviour {
	public CharacterMotor motor;

	public float BaseAnimationSpeed = 0.5f;
	public float AnimationSpeedModifier = 0.25f;

	Animation animation;

	// Use this for initialization
	void Start () {
		animation = GetComponent<Animation> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		animation[animation.clip.name].speed = motor.movement.velocity.magnitude *AnimationSpeedModifier + BaseAnimationSpeed;
	
	}
}
