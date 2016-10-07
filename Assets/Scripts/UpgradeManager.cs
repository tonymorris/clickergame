using UnityEngine;
using System.Collections;

public class UpgradeManager : MonoBehaviour {

	public Click click;
	public UnityEngine.UI.Text itemInfo;
	public float cost;
	public int count = 0;
	public int clickPower;
	public string itemName;
	private float _newCost;

	void Update(){
		itemInfo.text = itemName + "\nCost: " + cost + "\nPower: +" + clickPower;
	}

	public void PurchasedUpgrade(){
		if(click.gold >= cost) {
			click.gold -= cost;
			count += 1;
			click.goldperclick += clickPower;
			cost = Mathf.Round (cost * 1.15f);
			_newCost = Mathf.Pow (cost, _newCost = cost);
		}
	}
}