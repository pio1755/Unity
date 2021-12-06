using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad3 : MonoBehaviour
{
    public float speed = 10.0f;
    private bool lp = true;
    private bool gd = false;

    // Start is called before the first frame update

    void Start()
    {


    }

    // Update is called once per frame

    void Update()
    {
        float step = speed * Time.deltaTime;
        if (lp && gd)
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0, 0), step);
        if (!lp && gd)
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(10, 0, 10), step);
        if (lp && !gd)
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(10, 0, 0), step);
        if (!lp && !gd)
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0, 10), step);



        if ((transform.position.x == 10 && transform.position.z == 0))
        {
            transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
            lp = false;
            gd = true;
        }

        if ((transform.position.x == 10 && transform.position.z == 10))
        {
            transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
            lp = false;
            gd = false;
        }
        if ((transform.position.x == 0 && transform.position.z == 10))
        {
            transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
            lp = true;
            gd = true;
        }
        if ((transform.position.x == 0 && transform.position.z == 0))
        {
            transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
            lp = true;
            gd = false;
        }

    }
}