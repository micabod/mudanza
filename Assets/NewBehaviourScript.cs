using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float kgusuario;
    public float km;
    string tipovehiculo;
    float h_distancia;
    float precio;
    // Start is called before the first frame update
    void Start()
    {
        if (kgusuario < 100 || km <1){
            Debug.Log("error");
            return;
        }
        h_distancia =  km / 25;
        if (km>50){
            h_distancia = h_distancia + 1;
        }
        float cuentatipovehiculo = kgusuario * km;
        if (cuentatipovehiculo <= 2000){
            tipovehiculo = "Utilitario";
            precio = h_distancia*3000;  
        }
        if (cuentatipovehiculo <= 5000 && cuentatipovehiculo>2000){
            tipovehiculo = "Pickup";
            precio = h_distancia*4500;
        }
        if (cuentatipovehiculo <= 10000 && cuentatipovehiculo > 5000){
            tipovehiculo= "Camion";
            precio = h_distancia*7000;
        }
        Debug.Log("El tipo de vehiculo es"+ tipovehiculo);
        Debug.Log("La distancia es de"+ h_distancia+ "horas  por"+ km);
        Debug.Log("el precio es de"+ precio);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//Con &&, los dos tienen que estar mal juntos para que dé error.

//Con ||, con que uno esté mal ya es suficiente para dar error.

