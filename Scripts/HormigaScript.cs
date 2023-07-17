using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HormigaScript : MonoBehaviour
{
    private Animator Animator;
    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    void Update()
    {
        //Animator.SetBool("running", ); agregar condición para ejecutar animación de correr
    }
}
