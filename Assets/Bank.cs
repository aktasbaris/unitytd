using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bank : MonoBehaviour
{
	[SerializeField] int startingBalance = 150;
	[SerializeField] int currentBalance;

	public int getBalance()
	{
		return currentBalance;
	}

	void Awake()
	{
		currentBalance = startingBalance;
	}

	public void Deposit(int depositAmount)
	{
		currentBalance += Mathf.Abs(depositAmount);
	}

	public bool Withdraw(int withdrawAmount)
	{
		withdrawAmount = Mathf.Abs(withdrawAmount);
		bool flag = (withdrawAmount <= currentBalance);
		if (flag)
		{
			currentBalance -= withdrawAmount;
		}

		return flag;
	}
}
