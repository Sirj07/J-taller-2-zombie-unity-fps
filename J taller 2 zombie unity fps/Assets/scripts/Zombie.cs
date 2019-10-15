using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    

    
    public CosasZombie datosZombi; // variable de la estructura de los zombies
    
    int cambimovimiento; // variable para el cambio de moviento  
   
     

    void Awake() // se ejecuta antes del start
    {
        

        datosZombi.colorCaso = (CosasZombie.ColorZombie)Random.Range(0, 3); // genera un color para los zombies esta los casos del generador

        int Zgusto = Random.Range(0, 5);        // rango de los gustos del zombi
        datosZombi.sabor = (CosasZombie.Gustos)Zgusto; // da  los gustos 

    }
    void Start()
    {
        datosZombi.condicion = (CosasZombie.Estados)0;      // comienza las  corutinas del zombi o cambios de estado 
        StartCoroutine ("Cambioestado");
    }


    void Update()
    {
        

        switch(datosZombi.condicion) // casos del  la corrutina(movimiento) mas su condicion para ser usada primero rota y depues avanza
        {
            case CosasZombie.Estados.Idle:
                transform.eulerAngles += new Vector3(0, 0.5f, 0);
                break;
            case CosasZombie.Estados.Moving:
                if (cambimovimiento == 0)
                {
                    transform.position += new Vector3(0, 0, 0.03f);
                }
                else if (cambimovimiento == 1)
                {
                    transform.position -= new Vector3(0, 0, 0.03f);
                }
                else if(cambimovimiento == 2)
                {
                    transform.position -= new Vector3(0.03f, 0, 0.03f);
                }
                else if (cambimovimiento == 3)
                {
                    transform.position += new Vector3(0.03f, 0, 0);
                }
                break;
            default:
                break;
        }
       



    }
    
   
    IEnumerator Cambioestado() // la corutina se encar de cambiar los estado cada 5 segundo 
    {
        while (true)
        {
            if (datosZombi.condicion == (CosasZombie.Estados)0)
            {
                datosZombi.condicion = (CosasZombie.Estados)1;
                cambimovimiento = Random.Range(0, 4); //  la variable anterio da un numero random para los casos de moviento

            }
            else
            {
                datosZombi.condicion = (CosasZombie.Estados)0; 
            }
            yield return new WaitForSeconds(5); // tiempo
        }
    }

    
    

}



public struct CosasZombie    // la estructra que guarda los gustos , estados y colores deloszombies
{
    public enum Gustos  // emum con los gustos del zombie que se muestran en consola depues en hero 
    {
        Brazos,
        Piernas,
        Huesos,
        Ojitos,
        corazon
    };
   
    public Gustos sabor; 

    public enum Estados
    {
        Idle,
        Moving
    };
    public Estados condicion;

    public enum ColorZombie // color zombie de los casos usado en generador
    {
        magenta,
        green, 
        cyan
    };
    public ColorZombie colorCaso;
    
}