using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IZQControladorPinza : MonoBehaviour
{
    
    float Rotacion;
    public TopeAbajo topeAbajo;
    public bool topeUp = false;
    float vel = 0.5f;

    // private int limAbrir = 349;
    // private int limCerrar = 1;


    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "pinza"){
            topeUp =true;
        }
    }

    void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "pinza"){
            topeUp =false;
        }
    }



    void Pinza(float vel){
        //Rotacion = transform.eulerAngles.z;

        // if((Rotacion< limCerrar ||  Rotacion>limAbrir))
        // {
            if((Input.GetKey("down")) && (topeAbajo.topeDown == false)){
                //Rotacion += vel;
                transform.Rotate(Vector3.forward * vel);            
            }
          
            if(Input.GetKey("up") && (topeUp == false)){               
               //Rotacion += -vel;
               transform.Rotate(Vector3.forward * -vel);
                
            }
        //}
        // else if(Rotacion >=limCerrar && Rotacion < 180){
        //     Rotacion = 0.99f;
        // }
        // else if(Rotacion <=limAbrir && Rotacion > 180){
        //     Rotacion = 349.1f;
        // }
        //transform.rotation = Quaternion.Euler(0f,0f,Rotacion);
        
    }
    
    
    
    // Update is called once per frame
    void Update()
    {
        Pinza(vel);
        
    }
}
