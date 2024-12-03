using System;
using UnityEngine;

public class ColumnMove : MonoBehaviour
{
    [NonSerialized] public float speed = 1f; //NonSerialized данный атрибут не будет отображаться в самом unity

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
