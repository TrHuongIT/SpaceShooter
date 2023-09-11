using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManagerShoot : MonoBehaviour
{
    public AudioSource audioSourceShoot;
    // Start is called before the first frame update
    void Start()
    {
        audioSourceShoot = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
