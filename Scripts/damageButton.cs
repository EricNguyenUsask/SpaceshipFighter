using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class damageButton : MonoBehaviour
{

	public Button yourButton;
	public Projectile projectile;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		GameManager.instance.shopCost(3);
		projectile.setDamage(10);

	}
}
