using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Player;

    #region СвойтвоДистанции
    public float DistanceFromPlayer;


 
    void LateUpdate()
    {

        Vector3 EndPoint = Player.transform.position +new Vector3(0,0, DistanceFromPlayer);

        transform.position = Vector3.Lerp(transform.position, EndPoint, 4f);

        transform.LookAt(Player.transform);




   }
}
