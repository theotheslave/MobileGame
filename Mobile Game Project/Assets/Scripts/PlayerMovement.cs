using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public Joystick joystick;
    public float playerSPD = 40f;
    float horizontalMove = 0f;
    float verticalMove = 0f;


   
    void Update()
    {
        horizontalMove = joystick.Horizontal * playerSPD;





    }
}
