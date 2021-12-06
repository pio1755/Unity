using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad2 : MonoBehaviour
{
    public float doorSpeed = 3f;
    public float distance = 1f;
    private float startPosition;
    private float endPosition;
    private bool open = false;
    private bool close = false;

    void Start()
    {
        startPosition = transform.position.x;
        endPosition = transform.position.x - distance;
    }

    void FixedUpdate()
    {
        if (open && transform.position.x > endPosition)
        {
            transform.Translate(doorSpeed * Time.deltaTime, 0.0f, 0.0f);
        }
        else if (close && transform.position.x < startPosition)
        {
            transform.Translate(-doorSpeed * Time.deltaTime, 0.0f, 0.0f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player podszedl do drzwi.");
            open = true;
            close = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player odszedl od drzwi.");
            open = false;
            close = true;
        }
    }
}