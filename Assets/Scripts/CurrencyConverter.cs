using UnityEngine;
using System.Collections;

public class CurrencyConverter : MonoBehaviour {

	private static CurrencyConverter instance;
	public static CurrencyConverter Instance{
		get{
			return instance;
		}
	}

	void Awake(){
		CreateInstance ();
	}

	void CreateInstance(){
		if(instance == null) {
			instance = this;
		}
	}

/*
  Abbreviate money values with thousands, millions and billions
*/
	public string GetCurrencyIntoString(float valueToConvert, bool currencyPerSec, bool currencyPerClick){
		string converted;
		if(valueToConvert >= 1000000) {
			converted = (valueToConvert / 1000000f).ToString("f2") + " M";
		}else if (valueToConvert >= 1000){
			converted = (valueToConvert / 1000f).ToString("f2") + " K";
		}else if (valueToConvert >= 1000000000){
			converted = (valueToConvert / 1000000000f).ToString("f2") + " B"
		}else {
			converted = "" + Mathf.Round(valueToConvert);
		}

		if(currencyPerSec == true) {
				converted = converted + " gps";
		}

		if(currencyPerClick == true) {
				converted = converted + " gpc";
		}
		return converted;
}
}