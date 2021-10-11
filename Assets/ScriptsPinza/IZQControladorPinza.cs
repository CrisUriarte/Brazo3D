using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IZQControladorPinza : MonoBehaviour
{
    
    float Rotacion;

    private int limAbrir = 349;
    private int limCerrar = 1;

    void Pinza(float vel){
        Rotacion = transform.eulerAngles.z;

        if((Rotacion< limCerrar ||  Rotacion>limAbrir))
        {
            if(Input.GetKey("down")){
                Rotacion += vel;            
            }
          
            if(Input.GetKey("up")){               
               Rotacion += -vel;
                
            }
        }
        else if(Rotacion >=limCerrar && Rotacion < 180){
            Rotacion = 0.99f;
        }
        else if(Rotacion <=limAbrir && Rotacion > 180){
            Rotacion = 349.1f;
        }
        transform.rotation = Quaternion.Euler(0f,0f,Rotacion);
    }
    
    float vel = 0.1f;
    
    // Update is called once per frame
    void Update()
    {
        Pinza(vel);
    }
}
