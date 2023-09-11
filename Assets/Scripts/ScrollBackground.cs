using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    private float pointReplayHeight;
    private SpriteRenderer spriteRenderer;
    private Vector3 beginPosition;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        pointReplayHeight = spriteRenderer.size.y;

        beginPosition = transform.position;
        //Debug.Log(-pointReplayHeight/3);
        
    }

    // Update is called once per frame
    void Update()
    {
        Scroll();
    }

    public void Scroll()
    {
        transform.Translate(transform.position.x, -1 * Time.deltaTime, transform.position.z);
        if (transform.position.y <= -pointReplayHeight/3)
        {
            transform.position = beginPosition;
        }
    }
}
