using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DERControladorPinza : MonoBehaviour
{

    float Rotacion;
    int limCerrar= 359;
    int limAbrir = 11;


    void Pinza(float vel){
        Rotacion = transform.eulerAngles.z;

        if((Rotacion< limAbrir ||  Rotacion>limCerrar))
        {
            if(Input.GetKey("down")){
                Rotacion += -vel;            
            }
          
            if(Input.GetKey("up")){               
               Rotacion += vel;
                
            }
        }
        else if(Rotacion >=limAbrir && Rotacion < 180){
            Rotacion = 10.9f;
        }
        else if(Rotacion <=limCerrar && Rotacion > 180){
            Rotacion = 359.1f;
        }
        //Actualizacion de posicion (esta linea mueve todo, lo anterior suma a la posicion y aqui se actualiza)
        transform.rotation = Quaternion.Euler(0f,0f,Rotacion);
    }
    
    float vel = 0.1f;
    // Update is called once per frame
    void Update()
    {
        Pinza(vel);
    }
}
