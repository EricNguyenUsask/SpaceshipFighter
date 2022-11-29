using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Enemy : MonoBehaviour
{
    //Default Enemy stats
    [SerializeField] private float moveSpeed = 15.0f; 
    [SerializeField] public float health = 100.0f; 

    [SerializeField] private float damageToPlayer = 20.0f;
    [SerializeField] private float damageRate = 0.2f;
    [SerializeField] private float damageTime;

    public GameObject deathEffect;
    public GameObject coin;


    // Update is called once per frame
    void Update()
    {
        Movement(); 
    }

    private void Movement () {

        if (GameManager.instance.player) { //null reference check
            transform.LookAt(GameManager.instance.player.transform.position); //Look at the player
            transform.position += transform.forward * moveSpeed * Time.deltaTime;             
        }
        
    }

    public void dropCoin()
    {
        GameObject drop = Instantiate(coin, transform.position, transform.rotation);
        drop.transform.position = this.transform.position;
        drop.SetActive(true);

    }

    public void TakeDamage (float damage) {
        health -= damage;

        if (health <= 0) {
            GameObject effect = Instantiate(deathEffect, transform.position, transform.rotation);
            Destroy(effect, 1.0f); 
            Destroy(this.gameObject);
            dropCoin();
            
        }
        
    }
    

    

    void OnTriggerStay(Collider other) {
        if (other.transform.tag == "Player" && Time.time > damageTime) {
            other.transform.GetComponent<Player>().TakeDamage(damageToPlayer); 
            damageTime = Time.time + damageRate;             
        }        
    }
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Coin")
        {
            Physics.IgnoreCollision(collision.gameObject.GetComponent<Collider>(), GetComponent<Collider>());
        }

    }


}
