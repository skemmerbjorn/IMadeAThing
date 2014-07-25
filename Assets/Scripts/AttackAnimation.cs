using UnityEngine;
using System.Collections;

public class AttackAnimation : MonoBehaviour {

	public AnimationClip AttackAnimationClip;

	

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0))
						animation.Play (AttackAnimationClip.name);
				else if (animation [AttackAnimationClip.name].time > animation [AttackAnimationClip.name].length)
						animation.CrossFade (animation.clip.name);
	
	}


}
