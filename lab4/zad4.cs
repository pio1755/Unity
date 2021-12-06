using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad4 : MonoBehaviour
{
    // ruch wokół osi Y będzie wykonywany na obiekcie gracza, więc
    // potrzebna nam referencja do niego (konkretnie jego komponentu Transform)
    public Transform player;

    public float sensitivity = 200f;
    private float mouseYMove = 0;
    void Start()
    {
        // zablokowanie kursora na środku ekranu, oraz ukrycie kursora
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // pobieramy wartości dla obu osi ruchu myszy
    // Update is called once per frame
        float mouseXMove = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
         mouseYMove += Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
       
        // wykonujemy rotację wokół osi Y
        player.Rotate(Vector3.up * mouseXMove);

        // a dla osi X obracamy kamerę dla lokalnych koordynatów
        // -mouseYMove aby uniknąć ofektu mouse inverse
        mouseYMove = Mathf.Clamp(mouseYMove, -90f, 90f);
        transform.localRotation = Quaternion.Euler(-mouseYMove, 0f, 0f);

    }
}