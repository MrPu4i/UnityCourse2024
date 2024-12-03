using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    //��������� ������ ��������� ���� � �����
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float jumpForce = 1;
    [SerializeField] private Manager manager;
    void Start()
    {
        //����������� ���� ��� � ������
    }
    void Update() //�������� ���������
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    private void OnTriggerExit(Collider other) //� ������ ������ �� �������
    {
        manager.GetScore(other);
    }
    private void OnCollisionEnter(Collision collision) //Collision ������ ������� ��������� ������������, ����� �� ���� �������� ������, � ������� ��������� ������������
    {
        manager.Death(collision);
    }
}
