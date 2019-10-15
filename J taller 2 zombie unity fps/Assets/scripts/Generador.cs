using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    GameObject Objeto_Zombie; /* variable para se usada para crear al zombie 
                                y agregarle sus  componentes lo mismos para el aldeano */
    GameObject Objeto_Gente; 
    CosasZombie datoZombi; // varible usada para crear los zombies (colores )
   
    

    void Start()
    {

        /* crea de forma random los  personajes entre aldenos 
        y zombies con un objeto en forma de cubo hasta que se cumpla la condicion  */
        
        /* en las siguente lineas se agrega los componentes,posicion,nombre de lo objeto,
         y color en el caso de los zombies  y se les añade su respectivo script */

        
        
        
        int numPersonaje = Random.Range(9, 20);             
        for (int i = 0; i < numPersonaje; i++)
        {
           


            Objeto_Zombie = GameObject.CreatePrimitive(PrimitiveType.Cube);                       
            Objeto_Zombie.AddComponent<Zombie>();
            datoZombi = Objeto_Zombie.GetComponent<Zombie>().datosZombi;
            switch (datoZombi.colorCaso)                                                  
            {
                case CosasZombie.ColorZombie.magenta:
                    Objeto_Zombie.GetComponent<Renderer>().material.color = Color.magenta;

                    break;
                case CosasZombie.ColorZombie.green:
                    Objeto_Zombie.GetComponent<Renderer>().material.color = Color.green;

                    break;
                case CosasZombie.ColorZombie.cyan:
                    Objeto_Zombie.GetComponent<Renderer>().material.color = Color.cyan;

                    break;
            }
            Vector3 posicionzombie = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));        
            Objeto_Zombie.transform.position = posicionzombie;
            Objeto_Zombie.AddComponent<Rigidbody>();
            Objeto_Zombie.name = "Zombi";

            Objeto_Gente = GameObject.CreatePrimitive(PrimitiveType.Cube);                
            Objeto_Gente.AddComponent<Ciudadano>();
            Vector3 posicionGente = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));  
            Objeto_Gente.transform.position = posicionGente;
            Objeto_Gente.AddComponent<Rigidbody>();
            Objeto_Gente.name = "Gente";
            
            


        }
       

    }

    
  
}
