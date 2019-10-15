using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciudadano : MonoBehaviour
{
    public CosasCiudadanos datoCiudadanos;  //variable de la estructura del ciudadano

    void Awake() //se ejecuta antes del start
    {


        int Ramdm_nombre = Random.Range(0, 20);  //rando de los nombre del ciudadano usando el emum de los nombres
        datoCiudadanos.genteNombres = (CosasCiudadanos.Nombres)Ramdm_nombre;
        int Randm_edad = Random.Range(15, 100);                //random de la edad usando el emun de edad
        datoCiudadanos.edadgente = (CosasCiudadanos.Edad)Randm_edad; 

    }

    
   
}
public struct CosasCiudadanos  // estructuras y enum  con los nombres  y edad de los ciudadanos 
{
   public enum Nombres
    {
       rodrigo,
        robin,
        torre,
        pequeñi,
        don_juan,
        blue,
        saltin,
        sergio,
        estevan,
        tu_tia_en_tanga,
        tu_colega ,
        camilo,
        crespos,
        alexis,
        hay_te_va_sam_pedro,
        fly,
        jason,
        andrey,
        atreus,
        artion,
        alegandra,
        zeus,
        mauricio,
        puto_el_que_lo_lea,
        el_wilson_bolso,
        el_brayan,
        el_benites ,
        carlos,
    }
    public Nombres genteNombres;

    public enum Edad
    {
        edad
    }
    public Edad edadgente;
}
