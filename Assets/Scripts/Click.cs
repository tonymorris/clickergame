﻿using UnityEngine;
using System.Collections;

	public class Click : MonoBehaviour {

	public UnityEngine.UI.Text gpc;
	public UnityEngine.UI.Text goldDisplay;
	public float gold = 0;
	public int goldperclick = 1;

	void Update() {
		goldDisplay.text = "Gold: " + CurrencyConverter.Instance.GetCurrencyIntoString(gold);
		gpc.text = CurrencyConverter.Instance.GetCurrencyIntoString(goldperclick) + " gold/click";
	}

	public void Clicked() {
		gold += goldperclick;
	}
}