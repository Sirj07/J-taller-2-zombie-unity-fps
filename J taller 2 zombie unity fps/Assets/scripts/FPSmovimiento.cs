using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSmovimiento : MonoBehaviour
{
   
   
     public float velocidad ;// velocidad  del  personaje   
    string advertencia = "invertirmouse tambien para mejor funcionamiento boton en esfera"; // se crea una variable tipo string (cadena) la cual tiene un mesaje entre comillas 
     
	float mouseY; //  se define una variable  como tipo float(decimal) llamada  mouseX
    public bool invertirmovimiento=false; // se define una variable publica tipo bool(falso-verdadero)=a false

    void Start() 
    {
         velocidad = Random.Range(1f,2f); // pone una velocidad random al presionar  play en unity  
    }
    
     
    
   
	void Update() //se usa una funcion update que se actualiza constantemente  
	{
        
      
        if (invertirmovimiento==true) // se crea un condicional el cual si invertir movimiento es = a true  use la varible mouseX sera -= lo cual hace que mouse diriga 
        {                                        //  la direcion  este caso la  rotacion en el eje X 
            mouseY -= Input.GetAxis("Mouse X"); // resive y vuelve lo datos del mouse ademas de definir que entra se usar en este caso el mouse esto hace que se pueda usar  
            Debug.Log(advertencia); // imprime el mensaje en consola de la variable string
        }                                       // de manera invertida 
        else
        {
            mouseY += Input.GetAxis("Mouse X"); // si no seguira de forma normal 

        }

        transform.eulerAngles = new Vector3(0, mouseY, 0); //aqui se usa la  formacion  que se resive que mouse Y en el eje  Y  cual hace que se pude rota el objeto


        if (Input.GetKey(KeyCode.W)) //Se hace un condicional el cual  si se oprimi una de las siguente teclas se movera el la posion del objeto  
        {                            // + haci adelante menos haci atras  por la velocidad la cual determina cuanta distancia de movera 
            transform.position += transform.forward * velocidad ; // variable movimiento adelante  tecla w

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * velocidad ; // variable movimiento atras  tecla s

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * velocidad ; // variable  movimiento izquierda  tecla a

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * velocidad ; // // variable moviento derecha  tecla d
        }

 




    }
}
