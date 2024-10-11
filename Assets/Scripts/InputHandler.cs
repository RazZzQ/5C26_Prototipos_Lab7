using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private GameObject PlayerController;

    private IAimable _characterAim;
    private IMoveable _characterMovement;
    private IAttackable _characterAttack;

    private void Awake()
    {
        _characterAim = PlayerController.GetComponent<IAimable>();
        _characterMovement = PlayerController.GetComponent<IMoveable>();
        _characterAttack = PlayerController.GetComponent<IAttackable>();
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        //Debug.Log(context.ReadValue<Vector2>());

        //_characterMovement.Move(context.ReadValue<Vector2>());

        // Movimiento continuo mientras se mantiene la tecla presionada
        if (context.phase == InputActionPhase.Performed)
        {
            Vector2 direction = context.ReadValue<Vector2>();
            _characterMovement?.Move(direction);
        }
        else if (context.phase == InputActionPhase.Canceled)
        {
            _characterMovement?.Move(Vector2.zero);
        }
    }

    public void OnAim(InputAction.CallbackContext context)
    {
        //Debug.Log(context.ReadValue<Vector2>());

        _characterAim.Position = context.ReadValue<Vector2>();
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        //Debug.Log(context.phase);

        _characterAttack.Attack(_characterAim.Position);
    }
}
