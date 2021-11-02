using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float Rotacion;
    bool topeDer = false;
    bool topeIzq = false;


    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "pinza"){
            topeDer =true;
        }
    }

    void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "pinza"){
            topeDer =false;
        }
    }

  void probando(float vel){
        Rotacion = transform.position.x;
        
        if(Input.GetKey("down") && topeDer == false){
                Rotacion += -vel;            
            }
          
        if(Input.GetKey("up") && topeIzq == false){               
                Rotacion += vel;  
            }
        
        //Actualizacion de posicion (esta linea mueve todo, lo anterior suma a la posicion y aqui se actualiza)
        transform.position = new Vector3(Rotacion,0f,0f);
        Debug.Log(topeDer);
}

    // Update is called once per frame
    void Update()
    {
        probando(0.05f);
    }
}


//poner tag a pinza izquierda, que la pinza derecha sea la que ve si es que toca o no
//poner trigered a pinza izquierda
//poner script a la pinza derecha