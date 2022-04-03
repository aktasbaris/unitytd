using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	// Start is called before the first frame update
	[SerializeField] int goldReward = 25;
	[SerializeField] int goldPenalty = 25;

	Bank bank;

	void Start()
	{
		bank = FindObjectOfType<Bank>();
	}

	public void Reward()
	{
		if (bank == null)	return;
		bank.Deposit(goldReward);
	}

	public void Penalize()
	{
		if (bank == null) return;
		bank.Withdraw(goldPenalty);
	}
}
