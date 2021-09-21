using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MJoint : MonoBehaviour
{

public MJoint m_child;
public string DireccionRotacion;

public MJoint GetChild()
{
    return m_child;
}

  public void Rotar(float _angle) 
    {
        
        if(DireccionRotacion.ToUpper() == "UP")
        {
            this.transform.Rotate(Vector3.up * _angle);

        }
        else if(DireccionRotacion.ToUpper() == "DOWN")
        {
            this.transform.Rotate(Vector3.up * _angle);

        }
        else if(DireccionRotacion.ToUpper() == "FORWARD")
        {
            this.transform.Rotate(Vector3.forward * _angle);

        }
        else if(DireccionRotacion.ToUpper() == "BACK")
        {
            this.transform.Rotate(Vector3.back * _angle);
        }
        else if(DireccionRotacion.ToUpper() == "RIGHT")
        {
            this.transform.Rotate(Vector3.right * _angle);
        }
        else if(DireccionRotacion.ToUpper() == "LEFT")
        {
            this.transform.Rotate(Vector3.left * _angle);
        }
    }


}
