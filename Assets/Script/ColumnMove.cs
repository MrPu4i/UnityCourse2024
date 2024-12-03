using System;
using UnityEngine;

public class ColumnMove : MonoBehaviour
{
    [NonSerialized] public float speed = 1f; //NonSerialized ������ ������� �� ����� ������������ � ����� unity

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
