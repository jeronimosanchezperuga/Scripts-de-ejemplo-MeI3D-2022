using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploSwitch : MonoBehaviour
{
    public string nombre;
    // Start is called before the first frame update
    void Start()
    {
        switch (nombre)
        {
            case "Jeronimo":
                Debug.Log("Profe de MeI3D");
                break;
            case "Ivo":
                Debug.Log("Profe de IoT");
                break;
            case "Ranzo":
                Debug.Log("Profe de Front End");
                break;
            default:
                Debug.Log("No es un profe");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
