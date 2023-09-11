using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Transform pathTransfrom;
    private Vector3 directionTransform;

    private void Start()
    {
        directionTransform = transform.position - pathTransfrom.position;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, pathTransfrom.position, 5f * Time.deltaTime);
    }


}
