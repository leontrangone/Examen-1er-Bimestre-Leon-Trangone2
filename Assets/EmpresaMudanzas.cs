using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpresaMudanzas : MonoBehaviour
{

    public int cantKilos;
    public int distanciaARecorrer;

    int precioUtilitario = 3000;
    int precioPickup = 4500;
    int precioCamion = 7000;

    int precioFinal;

    // Start is called before the first frame update
    void Start()
    {
        if(cantKilos < 100 || distanciaARecorrer < 50)
        {
            Debug.Log("Ingrese datos válidos");
            return;
        }


        if(cantKilos < 2000)
        {
            precioFinal = ((distanciaARecorrer / 25) * precioUtilitario) + precioUtilitario;

            Debug.Log("Para esta mudanza se necesitara el un vehículo utilitario y el precio final de la mudanza es de " + precioFinal + ", y se cobrará 1 hora extra por gastos de regreso porque el viaje excede los 50km de distancia");
        }

        if (cantKilos < 5000 && cantKilos > 2000)
        {
            precioFinal = ((distanciaARecorrer / 25) * precioPickup) + precioPickup;

            Debug.Log("Para esta mudanza se necesitara el un vehículo PickUp y el precio final de la mudanza es de " + precioFinal +", y se cobrará 1 hora extra por gastos de regreso porque el viaje excede los 50km de distancia");
        }

        if (cantKilos < 10000 && cantKilos > 5000)
        {
            precioFinal = ((distanciaARecorrer / 25) * precioCamion) + precioCamion;

            Debug.Log("Para esta mudanza se necesitara el vehículo camión y el precio final de la mudanza es de " + precioFinal + ", y se cobrará 1 hora extra de gastos de regreso porque el viaje excede los 50km de distancia");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
