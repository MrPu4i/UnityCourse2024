using UnityEngine;

public class Deleter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Column")) //���������� ���� ����� == ������, ����� ������������, ���� CompareTag ������������
        {
            Destroy(other.gameObject);
        }
    }
}
