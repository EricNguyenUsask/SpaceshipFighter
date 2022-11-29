using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public Transform playerTransform;
    public float moveSpeed = 3f;

    CoinMovement coinMovementScript;
    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        coinMovementScript= gameObject.GetComponent<CoinMovement>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Magnet Trigger")
        {
            coinMovementScript.enabled = true;
        }
    }


}
