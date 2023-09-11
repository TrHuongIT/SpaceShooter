using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefabs;
    [SerializeField] private GameObject missilePrefabs;
    private bool shooting = false;

    private UIManager uiManager;
    // Start is called before the first frame update
    void Start()
    {
        uiManager = GameObject.Find("PlayerUI").GetComponent<UIManager>();
        shooting = true;
        InvokeRepeating("SpawnBullet", 0.1f, 0.1f);

    }

    // Update is called once per frame
    void Update()
    {
        float countTimer = Time.time;
        if (Input.GetKeyDown(KeyCode.B))
        {            
            shooting = !shooting;
            if (shooting)
            {
                InvokeRepeating("SpawnBullet", 0.1f, 0.1f);
                
            } 
            else
            {
                CancelInvoke();
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && shooting == false)
        {
            SpawnBullet();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            SpawnMissile();
        }

        if(countTimer >= 7f) 
        { 
            uiManager.DisableIntro(string.Empty); 
        }
    }

    public void SpawnBullet()
    {
        Instantiate(bulletPrefabs, transform.position, Quaternion.identity);
        MusicManagerShoot audio = GameObject.Find("MusicManagerShoot").GetComponent<MusicManagerShoot>();
        audio.audioSourceShoot.Play();
    }

    public void SpawnMissile()
    {
        Instantiate(missilePrefabs, transform.position, Quaternion.identity);
        MusicManagerShoot audio = GameObject.Find("MusicManagerShoot").GetComponent<MusicManagerShoot>();
        audio.audioSourceShoot.Play();
    }

    public void PressB()
    {
        shooting = !shooting;
        if (shooting)
        {
            InvokeRepeating("SpawnBullet", 0.1f, 0.1f);

        }
        else
        {
            CancelInvoke();
        }
    }

    public void PressQ()
    {
        SpawnMissile();
    }

    public void PressX()
    {
        Application.Quit();
    }
}
