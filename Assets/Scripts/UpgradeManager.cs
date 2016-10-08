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

	void Start(){
		baseCost = cost;
		_slider = GetComponentInChildren<Slider> ();
	}

	void Update(){
		itemInfo.text = itemName + "\nCost: " + cost + "\nPower: +" + clickPower;
		_slider.value = click.gold / cost * 100;
	}

	public void PurchasedUpgrade(){
		if(click.gold >= cost) {
			PlayerPrefs.SetFloat("Gold", click.gold -= cost);
			click.goldperclick += clickPower;
			count += 1;
			cost = Mathf.Round (baseCost * Mathf.Pow (1.15f, count));
		}
	}
}