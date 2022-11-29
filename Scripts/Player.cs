using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5.0f;
    [SerializeField] private float rotateSpeed = 360.0f; 
    private Vector3 position; 
    [SerializeField] private Vector3 _rotation; 

    [SerializeField] public float health = 100.0f; 
    
    public GameObject deathEffect;


    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    //Player Input Controls
    private void MovePlayer() {
        //Forward & Backward Movement 
        if (Input.GetKey(KeyCode.W)) transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime); 
        if (Input.GetKey(KeyCode.S)) transform.Translate(Vector3.back * moveSpeed * Time.deltaTime); 

        //Left and Right Rotation
        if (Input.GetKey(KeyCode.D)) _rotation = Vector3.up;
        else if (Input.GetKey(KeyCode.A)) _rotation = Vector3.down; 
        else _rotation = Vector3.zero; 
        transform.Rotate(_rotation * rotateSpeed * Time.deltaTime); 

    }
    public void setHealth()
    {
        health = 1000;
    }

    public void TakeDamage (float damage) {
        health -= damage; 

        if (health <= 0) {
            GameObject effect = Instantiate(deathEffect, transform.position, transform.rotation);
            Destroy(effect, 1.0f); 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}


