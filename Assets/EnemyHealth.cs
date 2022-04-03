using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoints = 10;
    [SerializeField] int currentHitPoints;
	Enemy enemy;

    void OnEnable()
    {
        currentHitPoints = maxHitPoints;
    }

	void Start()
	{
		enemy = GetComponent<Enemy>();
	}
	void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    void ProcessHit()
    {
        currentHitPoints--;
        if(currentHitPoints <= 0)
        {
			enemy.Reward();
            gameObject.SetActive(false);
        }
    }
}
