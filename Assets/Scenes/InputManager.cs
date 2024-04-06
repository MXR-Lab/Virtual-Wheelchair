using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class InputManager : MonoBehaviour
{/*
    [Header("Actions")]
    public SteamVR_Action_Boolean touch;
    public SteamVR_Action_Boolean press;
    public SteamVR_Action_Vector2 touchPosition;

    [Header("Scene Objects")]
    public RadialMenu radialMenu;
    //public Pointer pointer;

    private void Awake()
    {
        touchPosition.AddOnAxisListener(Position, SteamVR_Input_Sources.RightHand);
        touch.AddOnChangeListener(Touch, SteamVR_Input_Sources.RightHand);
        press.AddOnStateUpListener(PressRelease, SteamVR_Input_Sources.RightHand);
    }

    private void Position(SteamVR_Action_Vector2 fromAction, SteamVR_Input_Sources fromSource, Vector2 axis, Vector2 delta)
    {
        radialMenu.SetTouchPosition(axis);
    }

    private void Touch(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource, bool newState)
    {
        radialMenu.Show(newState);
        //pointer.ToggleVisibility(newState);
    }

    private void PressRelease(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        radialMenu.ActivateHighlightedSection();
    }
*/}
