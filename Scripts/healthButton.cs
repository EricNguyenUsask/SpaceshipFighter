using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthButton : MonoBehaviour
{
	public Button yourButton;
	public Player player;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		GameManager.instance.shopCost(2);
		player.setHealth();
	}
}
