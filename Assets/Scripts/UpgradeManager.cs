using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour {

	public Click click;
	public UnityEngine.UI.Text itemInfo;
	public float cost;
	public int count = 0;
	public int clickPower;
	public string itemName;
	private float baseCost;
	private Slider _slider;
	public float goldd;
	public int baseGoldpc;

	void Awake(){
		goldd = PlayerPrefs.GetFloat ("Gold");
	}

	void Start(){
		baseCost = cost;
		_slider = GetComponentInChildren<Slider> ();
	}

	void Update(){
		itemInfo.text = itemName + "\nCost: " + cost + "\nPower: +" + clickPower;
		_slider.value = click.gold / cost * 100;
	}

	public void PurchasedUpgrade(){
		if(goldd >= cost) {
			PlayerPrefs.SetFloat("Gold", goldd -= cost);
			count += 1;
			baseGoldpc += clickPower;
			cost = Mathf.Round (baseCost * Mathf.Pow (1.15f, count));
		}
	}
}