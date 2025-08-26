using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Button : MonoBehaviour
{
    Transform button;
    bool readytopress;
    [SerializeField] LayerMask layer;
    [SerializeField] float radius;
    [SerializeField] Jailcontroller jailcontroller;
    Collider[] list;
    [SerializeField] Key tecla = Key.F;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        list = Physics.OverlapSphere(button.position,radius,layer);

        if(list.Length > 0)
        {
            Debug.Log("Se activo la opcion");
            ActiveJail();
        }
        if(list.Length <= 0)
        {
            if (!jailcontroller.isinposition)
            {
                Debug.Log("Se desactivo");
                jailcontroller.Resetjail();
            }
        }

        if (Keyboard.current != null && Keyboard.current[tecla].wasPressedThisFrame)
        {
            jailcontroller.isinposition = false;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(button.position, radius);
    }

    public void ActiveJail()
    {
        jailcontroller.Falljail();
    }
}
