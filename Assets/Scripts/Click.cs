﻿using UnityEngine;
using System.Collections;

	public class Click : MonoBehaviour {

	public UnityEngine.UI.Text gpc;
	public UnityEngine.UI.Text goldDisplay;
	public float gold;
	public int goldperclick;

	void Awake(){
		gold = PlayerPrefs.GetFloat ("Gold");
	}

	void Update() {
		goldDisplay.text = "Gold: " + CurrencyConverter.Instance.GetCurrencyIntoString(gold, false, false);
		gpc.text = CurrencyConverter.Instance.GetCurrencyIntoString(goldperclick, false, false) + " gold/click";
	}

	public void Clicked() {
		PlayerPrefs.SetFloat("Gold", gold += goldperclick);
	}
}