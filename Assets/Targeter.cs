using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targeter : MonoBehaviour
{
    [SerializeField] Transform weapon;
	[SerializeField] ParticleSystem boltParticles;
	[SerializeField] float maxRange = 15f;
    Transform target;

    void Update()
	{
		FindClosestTarget();
		AimWeapon();
	}

	void AimWeapon()
	{
		float targetDistance = Vector3.Distance(target.position, transform.position);

		weaponActive(targetDistance <= maxRange);
		weapon.LookAt(target);
	}

	void FindClosestTarget()
    {
        float currentDistance = Mathf.Infinity;
        Transform currentTarget = null;
        Enemy[] enemies = FindObjectsOfType<Enemy>();

        foreach(Enemy enemy in enemies)
        {
            float tempDistance = Vector3.Distance(transform.position, enemy.transform.position);

			if(tempDistance < currentDistance)
			{
				currentDistance = tempDistance;
				currentTarget = enemy.transform;
			}

        }

		target = currentTarget;
    }

	void weaponActive(bool isActive)
	{
		var em = boltParticles.emission;
		em.enabled = isActive;
	}
}
