using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ButtonController :MonoBehaviour
{
   public float GameSpeed;
    public GameObject Main_Menu_Condition; // ������ �� ������� ����



    public void InputPlay() /* ����� ��� ������������� �������� ����������� ������� ������ 
                              (��� ������� �� ������ Play � ������� ����)*/
    {
        Main_Menu_Condition.SetActive(false);
        EventManager.EventPlay?.Invoke(GameSpeed);
    }

     

    
}
