using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement3D : MonoBehaviour, IMoveable
{
    public float speed = 5f;

    public void Move(Vector2 direction)
    {
        // Movimiento en el plano 3D (X y Z)
        Vector3 movement = new Vector3(direction.x, 0f, direction.y);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
