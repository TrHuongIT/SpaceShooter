using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListEnemy : MonoBehaviour
{
    public GameObject[] enemy;
    public ShapeDot dotSquare;
    public ShapeDot dotRhombus;
    public ShapeDot dotTriangle;
    public ShapeDot dotRect;

    public GameObject enemyPrefabs;
    public bool summon;

    private void Awake()
    {
        for (int i = 0; i < 16; i++)
        {
            enemy[i] = Instantiate(enemyPrefabs, transform.position, Quaternion.identity);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //dot = GameObject.Find("Square").GetComponent<ShapeDot>();
        //Debug.Log(dot.dotPoint[0].transform.position);
        summon = true;

        
        
            
    }

    // Update is called once per frame
    void Update()
    {
        float count = Time.time;
        if(count <= 5f && summon)
        {
            SpawnSquare();
        }
        else if(5f < count && count <= 10f && summon)
        {
            SpawnRhombus();
        } 
        else if (10f < count && count <= 15f && summon)
        {
            SpawnTriangle();
        }
        else if (15f < count && count <=20f && summon)
        {
            SpawnRect();
        } else
        {
            summon = false;
        }
        

    }

    public void SpawnSquare()
    {  

        for (int i = 0; i < enemy.Length; i++)
        {
            enemy[i].transform.position = Vector3.MoveTowards(enemy[i].transform.position, dotSquare.dotPoint[i].transform.position, 5f * Time.deltaTime);
        }
    }

    public void SpawnRhombus()
    {

        for (int i = 0; i < enemy.Length; i++)
        {
            enemy[i].transform.position = Vector3.MoveTowards(enemy[i].transform.position, dotRhombus.dotPoint[i].transform.position, 5f * Time.deltaTime);
        }
    }

    public void SpawnTriangle()
    {

        for (int i = 0; i < enemy.Length; i++)
        {
            enemy[i].transform.position = Vector3.MoveTowards(enemy[i].transform.position, dotTriangle.dotPoint[i].transform.position, 5f * Time.deltaTime);
        }
    }

    public void SpawnRect()
    {

        for (int i = 0; i < enemy.Length; i++)
        {
            enemy[i].transform.position = Vector3.MoveTowards(enemy[i].transform.position, dotRect.dotPoint[i].transform.position, 5f * Time.deltaTime);
        }
    }
}
