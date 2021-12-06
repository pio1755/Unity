using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad2 : MonoBehaviour
{
    public float speed = 10.0f;
    public float step = speed * Time.deltaTime;
    private bool move = true;
    
    // Start is called before the first frame update
    
    void Start()
    {
        transform.position = new Vector3(0.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x == 10 || transform.position.x == 0)
            move = !move;
        if (move)
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(10,0,0), step);
        else
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0, 0), step);
    }
}
