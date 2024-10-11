using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour, IMoveable
{
    public float speed = 5f;

    public void Move(Vector2 direction)
    {
        // Movimiento en 2D (X e Y)
        Vector3 movement = new Vector3(direction.x, direction.y, 0f);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
