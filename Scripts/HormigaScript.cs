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
        //Animator.SetBool("running", ); agregar condici�n para ejecutar animaci�n de correr
    }
}
