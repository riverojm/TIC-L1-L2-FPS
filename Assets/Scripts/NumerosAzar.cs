using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumerosAzar : MonoBehaviour
{
    [SerializeField] int RandomNumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            NumeroAleatorio();
        }
    }

    void NumeroAleatorio()
    {
        RandomNumber = Random.Range(0, 4);
    }
}
