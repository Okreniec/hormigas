using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HormigaScript : MonoBehaviour
{
    public bool movimientoRealizado = false;
    public bool isPlacedInRoom = false;

    public float velocidad = 10f;

    private Animator Animator;
    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    void Update()
    {
        
        //Animator.SetBool("working", ); agregar condición para ejecutar animación de trabajo

        if (!movimientoRealizado && !isPlacedInRoom)
        {
            float mitadPantallaX = Camera.main.pixelWidth / 2.45f;
            float mitadPantallaWorldX = Camera.main.ScreenToWorldPoint(new Vector3(mitadPantallaX, 0f, 0f)).x;
            Animator.SetBool("running", true);

            transform.Translate(velocidad * Time.deltaTime, 0, 0);

            if (transform.position.x >= mitadPantallaWorldX)
            {
                Animator.SetBool("running", false);
                velocidad = 0f;
                movimientoRealizado = true;
            }
        }
    }
}
