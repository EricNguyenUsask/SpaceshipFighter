using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quitButton : MonoBehaviour
{
	public Button yourButton;
	public GameObject shop;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClickQuit);
		
	}

	void TaskOnClickQuit()
	{
		shop.SetActive(false);
		Time.timeScale = 1;

	}
}
