using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private Vector2 direction;
    [SerializeField] private float moveSpeed;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        Walk();
    }


    private void Walk()
    {
        direction = new Vector2(InputsManager.GetMovementInput().x, InputsManager.GetMovementInput().y).normalized;
        rigidbody.velocity = direction * moveSpeed;
    }
}
