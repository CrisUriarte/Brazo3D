using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IkManager2 : MonoBehaviour
{

    public MJoint m_end;
    public MJoint m_root;
    public GameObject m_target;
    float threshold = 0.001f;
    float vel = 5;
    public int pasos = 5;

    float CalculateDistance(Vector3 p1, Vector3 p2){
        return Vector3.Distance(p1, p2);
    }

    float CalculateSlope(MJoint _joint)
    {
        float DeltaTheta = 0.01f; 
        float distance1 = CalculateDistance(m_end.transform.position, m_target.transform.position);

        //Rotar la articulacion;
        _joint.Rotar(DeltaTheta);

        float distance2 = CalculateDistance(m_end.transform.position, m_target.transform.position);

        //Rotar a la posición original
        _joint.Rotar(-DeltaTheta);

        return (distance1 - distance2) / DeltaTheta;
    }

    void Update()
    {
       MJoint current = m_root;
       float  error = CalculateDistance(m_end.transform.position, m_target.transform.position);

       if(error>threshold){
           for(int i=0;i<pasos;++i){
               while(current != null)
                {
               float slope = CalculateSlope(current);
               current.Rotar(slope * vel);
               current = current.GetChild();
                }
           }
           

       }
    }
}
