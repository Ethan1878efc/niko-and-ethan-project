using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public float Yposition;

    Vector3 targetposition;

    // Start is called before the first frame update
    void Start()
    {
        GetRandomTarget();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetposition, speed * Time.deltaTime);
        if (transform.position == targetposition)
        {
            GetRandomTarget();
        }
    }

    void GetRandomTarget()
    {
        float randomX = Random.Range(minX, maxX);
        float randomZ = Random.Range(minZ, maxZ);
        targetposition = new Vector3(randomX, Yposition, randomZ);
    }
}
