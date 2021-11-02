using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopeAbajo : MonoBehaviour
{
    public bool topeDown = false;
    

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "pinza"){
            topeDown = true;
        }
    }

    void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "pinza"){
            topeDown =false;
        }
    }

}


