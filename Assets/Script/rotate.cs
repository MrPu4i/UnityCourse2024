using UnityEngine;
using UnityEngine.SceneManagement;

public class rotate : MonoBehaviour
{
    //������ ������� ������������ �� y
    [SerializeField] private float rotationSpeed = 1f;
    void Start()
    {
        //DontDestroyOnLoad(this);
        //� ������� ������� ������� ��� ����� ������, ������� �� ������� �������
        //����� ����� ���� ������������� �����, ���-�� ����� � ����
    }

    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.UnloadSceneAsync(1); // �� ����� ���������, ����� ��� ��� ������ ���-�� ���������. ����������. ����� �����
            //������� ��������. �������� �������� ����� �����������. ����� ���������� - ����� ��������� �� ��������.
            SceneManager.LoadScene(1, LoadSceneMode.Additive);
        }
    }
}
