using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private int maxHealth = 5;
    private ListEnemy listEnemy;
    private UIManager uiManager;

    public GameObject explosion;
    private GameObject cloneExplosion;
    // Start is called before the first frame update
    void Start()
    {
        listEnemy = GameObject.Find("Enemy").GetComponent<ListEnemy>();
        uiManager = GameObject.Find("PlayerUI").GetComponent<UIManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (listEnemy.summon == false)
        {
            if (collision.gameObject.tag == "Bullet")
            {
                
                maxHealth -= 1;
                if (maxHealth <= 0)
                {
                    MusicManager audio = GameObject.Find("MusicManager").GetComponent<MusicManager>();
                    audio.audioSourceDead.Play();
                    cloneExplosion =  Instantiate(explosion, transform.position, Quaternion.identity);
                    cloneExplosion.GetComponent<Animator>().Play("explosion", 0);           
                    
                    //Destroy(gameObject);
                    gameObject.SetActive(false);
                    uiManager.UpdateScore();
                    Destroy(cloneExplosion, 2f);
                }
            }
        }
        else return;          

        
    }
}
