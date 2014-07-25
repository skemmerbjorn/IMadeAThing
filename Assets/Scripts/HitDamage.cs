using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Stats))]
public class HitDamage : MonoBehaviour, IHitable {

	public AudioClip deathClip;
	Stats stats;

	void Start() 
	{
	stats = GetComponent<Stats> ();
	}

	public void Hit ()
	{
				stats.Health -= 10;

				if (stats.Health <= 0)
		{
						Destroy (gameObject, 1);
				audio.PlayOneShot (deathClip);
		}

}

}