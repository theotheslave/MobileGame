using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ETouch = UnityEngine.InputSystem.EnchancedTouch;
public class Movement : MonoBehaviour
{

    [SerializedField]
    private Vector2 JoystickSize = new Vector2(300, 300);
    [SerializedField]
    private FloatingJoystick Joystick;
    [SerializedField]
    private UnityEngine.AI.NavMeshAgent Player;


    private Finger MovementFinger;
    private Vector2 MovementAmount;



private void OnEnable()
    {
        EnhancedTouchSupport.Enable();
        ETouch.Touch.onFingerDown += Touch_onFingerDown;
        ETouch.Touch.onFingerUp += Touch_onFingerUp;
        ETouch.Touch.onFingerMove += Touch_onFingerMove;
    }

    private void OnDisable()
    {


        ETouch.Touch.onFingerDown -= Touch_onFingerDown;
        ETouch.Touch.onFingerUp -= Touch_onFingerUp;
        ETouch.Touch.onFingerMove -= Touch_onFingerMove;
        EnhancedTouchSupport.Disable;
    }

    private void HandleFingerDown (Finger TouchedFinger)
    {
        if (MovementFinger == null && TouchedFinger.screenPosition.x <= Screen.width / 2f)
        {


        }





    }

}
