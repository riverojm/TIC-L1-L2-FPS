using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarElementosArray : MonoBehaviour
{
    [SerializeField] GameObject[] ObjetosInstanciar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            InstanciarObjeto(ObjetosInstanciar[Random.Range(0, ObjetosInstanciar.Length + 1)]);
        }
    }

    void InstanciarObjeto(GameObject objeto)
    {
        objeto.AddComponent<BoxCollider>();
        objeto.AddComponent<Rigidbody>();
        Instantiate(objeto, transform.position,transform.rotation);
    }
}
