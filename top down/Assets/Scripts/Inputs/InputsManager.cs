using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputsManager : MonoBehaviour
{

    private InputsActions actions;
    public static InputsManager instance;

     Vector2 moveInput;

    private void Awake()
    {
        actions = new InputsActions();
        actions.Enable();

        if (instance == null) 
        {
            instance = this;
        }
        else
        {
            Destroy(instance);
        }
    }

    private void Update()
    {
        onMove();
    }

    private void onMove()
    {
        moveInput = actions.PlayerInputs.MOVEMENT.ReadValue<Vector2>();
    }

    public static Vector2 GetMovementInput()
    {
        return instance.moveInput;
    }
}
