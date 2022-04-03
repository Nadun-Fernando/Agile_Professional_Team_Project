using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    private int count = 2;
    public int wave = 1;

    public GameObject[] enemy;
    private int enemyCount;

    public GameObject[] prefabEnemy;
    public float spawnRangeX = 3.64f;
    public float spawnRangeY = 0;
    public float spawnLocZ = 8.6f;
    public float delayStart = 2;
    public float spawnInterval = 1.5f;
   

    public GameObject parent;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemy = GameObject.FindGameObjectsWithTag("enemy");
        enemyCount = enemy.Length;
        if (enemyCount == 0  )
        {
            while (count > 1)
            {
                SpawnRandomEnemies();
                count = count - 1;

            }
            wave = wave + 1;
            count = 1 * wave; 
        } 
    }
    
    public  void SpawnRandomEnemies()
    {
        int enemyIndex = Random.Range(0, prefabEnemy.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnRangeY, spawnLocZ);
        Instantiate(prefabEnemy[enemyIndex], spawnpos, prefabEnemy[enemyIndex].transform.rotation,parent.transform);
        
    }
}
