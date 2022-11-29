using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null; 
    public GameObject player;
    public GameObject shop;
    //Score variables
    public Text scoreText;
    public int score = 0;
    quitButton quit;
    


    void Awake() {
        if (instance == null) {
            instance = this;
        } 

        else if (instance != this) {
            Destroy(gameObject); 
        }
    }

    void Start () {
        SetScoreText();        
    }
    void Update()
    {

        if (ReturnScore() == 2)
        {
            shop.SetActive(true);
            Time.timeScale = 0f;

        }


    }

    void SetScoreText() {
      scoreText.text =  "Score: " + score.ToString(); //This will allow us to concatonate two strings in C#    
    }


    public void AddPoints(int scoreToAdd) {
        score += scoreToAdd;    
        //Debug.Log(score);
        SetScoreText();    
    }

    public void shopCost(int price)
    {

        score -=price;
        SetScoreText();
    }


    public int ReturnScore() {
        return score;

    }


}

