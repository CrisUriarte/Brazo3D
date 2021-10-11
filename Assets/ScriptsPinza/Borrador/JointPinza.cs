using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointPinza : MonoBehaviour
{
public string Direccion;
public int _sentido = 1;
int a = 1;

private int limInf = 349;
private int limSup = 359;



//Quaternion q = new Quaternion(0.0f, 0.0F, -0.1F, 1.0F); // limite para abrir la pinza
//Quaternion q2 = new Quaternion(0.0f, 0.0F, 0.0F, 1.0F); // limite para cerrar la pinza

/*
Mueve la pieza de directo a la posicion 

public float Local_X =0.0f;
public float Local_Y = 0.0f;
public float Local_Z = 30.0f;
transform.localRotation = Quaternion.Euler(Local_X, Local_Y, Local_Z);

condicion de limite de rotacion
q[2] < transform.rotation[2]
*/




public void Rotaciones(int _angle, int sentido)
{
    Debug.Log("entra en la funcion de rotacion");
    //PINZA IZQUIERDA
    if(Direccion == "FORWARD" && sentido == 1)
            {
            transform.Rotate(Vector3.forward * -_angle);
            }

    if(Direccion == "FORWARD" && sentido == 0)
            {
            this.transform.Rotate(Vector3.forward * _angle);
            } 
    //PINZA DERECHA 
    if(Direccion == "BACK" && sentido == 1)
            {
            transform.Rotate(Vector3.back * -_angle);
            }

    if(Direccion == "BACK" && sentido == 0)
            {
            this.transform.Rotate(Vector3.back * _angle);
            } 

}


// Update is called once per frame
void Update()
    {   
        float anguloActual = transform.eulerAngles.z;
        Debug.Log(anguloActual);
        
        if((anguloActual>limInf) &&(anguloActual<limSup))
        {
            Debug.Log("entra al primer if");

            if(Input.GetKey("left") ){
            _sentido = 1;
            //Debug.Log("entra al apretar el boton");
            Rotaciones(a, _sentido);
            }

            if(Input.GetKey("right")){
            //Debug.Log("entra al apretar el boton");
            _sentido = 0;
            Rotaciones(a, _sentido);
            }
        }
        else if((anguloActual<=limInf) && (anguloActual>180))
        {
            Debug.Log("entra al segundo if");
            anguloActual = limInf + 1;
        }
        else if((anguloActual<=limInf) && (anguloActual<180))
        {
            Debug.Log("entra al tercer if");
            anguloActual = 90f;
        }
        else{
            Debug.Log("no entra a ni uno");
        }
        
        
    }
}
