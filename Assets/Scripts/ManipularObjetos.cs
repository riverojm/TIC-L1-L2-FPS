using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipularObjetos : MonoBehaviour
{
    [SerializeField]GameObject[] Sillas;
    // Start is called before the first frame update
    void Start()
    {
        Sillas = GameObject.FindGameObjectsWithTag("Silla");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            DisableArrayElements();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            EnableArrayElements();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            AgregarRBArray();
            AgregarColliderArray();
        }
    }

    void DisableArrayElements()
    {
        for (int i = 0; i < Sillas.Length; i++)
        {
            Sillas[i].SetActive(false);
        }
    }

    void EnableArrayElements()
    {
        for (int i = 0; i < Sillas.Length; i++)
        {
            Sillas[i].SetActive(true);
        }
    }

    void AgregarRBArray()
    {
        for (int i = 0; i < Sillas.Length; i++)
        {
            Sillas[i].AddComponent<Rigidbody>();
        }
    }

    void AgregarColliderArray()
    {
        for (int i = 0; i < Sillas.Length; i++)
        {
            Sillas[i].AddComponent<BoxCollider>();
        }
    }
}
