using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationXY : MonoBehaviour, IMoveable
{
    public float rotationSpeed = 100f;

    public void Move(Vector2 direction)
    {
        // Rotación en los ejes X e Y
        Vector3 rotation = new Vector3(direction.y, direction.x, 0f);
        transform.Rotate(rotation * rotationSpeed * Time.deltaTime);
    }
}
