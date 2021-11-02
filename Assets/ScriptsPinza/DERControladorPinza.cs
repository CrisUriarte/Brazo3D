using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DERControladorPinza : MonoBehaviour
{

    float Rotacion;
    public TopeAbajo topeAbajo;
    public IZQControladorPinza controlIZQ;
    
    float vel = 0.5f;


    void Pinza(float vel){

        // if((Rotacion< limAbrir ||  Rotacion>limCerrar))
        // {
            if(Input.GetKey("down") && (topeAbajo.topeDown == false)){
                transform.Rotate(Vector3.forward * -vel);          
            }
          
            if(Input.GetKey("up") && (controlIZQ.topeUp == false)){               
               transform.Rotate(Vector3.forward * vel);
                
            }
        // }
        // else if(Rotacion >=limAbrir && Rotacion < 180){
        //     Rotacion = 10.9f;
        // }
        // else if(Rotacion <=limCerrar && Rotacion > 180){
        //     Rotacion = 359.1f;
        // }
        //Actualizacion de posicion (esta linea mueve todo, lo anterior suma a la posicion y aqui se actualiza)
        //transform.rotation = Quaternion.Euler(0f,0f,Rotacion);
    }
    
    
           
    
    void Update()
    {
        Pinza(vel);
        //Debug.Log("tope arriba" + topeAbajo.topeDown);
        //Debug.Log(transform.eulerAngles.z);
        
    }
}
