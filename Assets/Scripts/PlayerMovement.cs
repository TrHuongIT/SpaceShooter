using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 5f;
    private Vector2 moveDir = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShipMove(Vector2 input)
    {
        moveDir.x = input.x;

        transform.Translate(moveDir * speed * Time.deltaTime);

    }

    public void ShipMoveTouchscreen(Vector2 input)
    {
        moveDir.x = input.x;
        transform.Translate(moveDir * 0.25f * Time.deltaTime);   
    }
}
