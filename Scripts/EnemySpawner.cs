using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyPrefab;
    [SerializeField] Camera Camera;

    [SerializeField] private float spawnRate = 2.0f;
    private float spawnTimer;
    public int enemyNum;
    private Canvas HealthBarCanvas;


    // Start is called before the first frame update
    void Start()
    {
        enemyNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemy(); 
    }






    void SpawnEnemy()
    {
        Vector3 pos = new Vector3(
           Random.Range(-10,10),
           0,
           Random.Range(-10, 10)
           );

        if (Time.time > spawnTimer)
        {
            GameObject enemy= Instantiate(enemyPrefab, pos, transform.rotation);
            enemy.GetComponent<Enemy>().health = enemy.GetComponent<Enemy>().health +  enemyNum;
            enemyNum++;
            spawnTimer = Time.time + spawnRate;
           // Debug.Log(enemy.GetComponent<Enemy>().health);



        }

    }

}
