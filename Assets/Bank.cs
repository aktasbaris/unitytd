using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Bank : MonoBehaviour
{
	[SerializeField] int startingBalance = 150;
	[SerializeField] int currentBalance;
	[SerializeField] TextMeshProUGUI label;

	public int GetBalance()
	{
		return currentBalance;
	}

	void Awake()
	{
		currentBalance = startingBalance;
		UpdateText(currentBalance);
	}

	void UpdateText(int newBalance)
	{
		label.text = "Gold: " + newBalance;
	}

	public void Deposit(int depositAmount)
	{
		currentBalance += Mathf.Abs(depositAmount);
		UpdateText(currentBalance);
	}

	public void Withdraw(int withdrawAmount)
	{
		currentBalance -= Mathf.Abs(withdrawAmount);
		UpdateText(currentBalance);
	}
}
