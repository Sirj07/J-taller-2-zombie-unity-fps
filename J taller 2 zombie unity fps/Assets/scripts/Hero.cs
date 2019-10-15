using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
     CosasZombie datosZombi; //variables de las estructra de los zombies
    CosasCiudadanos datoCiudadanos;//variables de las estructra de los aldeanos 
  

     private void OnCollisionEnter(Collision collision)     //la funcion colicion de colision segun el nombre del objeto
    {
        if (collision.transform.name == "Zombi") // si coliciona con un zombi este le crea un mensaje que aparece en consola y tiene los gusto del zombi que  esta en script del zombie
        {
            datosZombi = collision.gameObject.GetComponent<Zombie>().datosZombi;
            Debug.Log("  waaarrr " + " quiero comer " +  datosZombi.sabor);
        }


        if (collision.transform.name == "Gente") //si coliciona con un aldeano este le crea un mensaje que aparece en consola que tiene los nombre y edades de los aldeanos en el script del ciudadano
        {
            datoCiudadanos = collision.gameObject.GetComponent<Ciudadano>().datoCiudadanos;
            Debug.Log("Hola soy " + datoCiudadanos.genteNombres+ " y tengo " + datoCiudadanos.edadgente);
        }
    }



}



