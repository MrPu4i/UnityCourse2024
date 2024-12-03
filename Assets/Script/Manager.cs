using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Manager : MonoBehaviour
{
    [SerializeField] private ColumnSpawner colSpawn;
    [SerializeField] private Player player;
    [SerializeField] private TextMeshProUGUI scoreText; //TextMeshPro ���������� ������� ����� ���������� �� �����, c UGUI ��� ��������� �����
    [SerializeField] private GameObject gameOver_Screen;

    private int score = 0;
    public void Restart()
    {
        //������� ����� ������� �� ����� ���������
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GetScore(Collider other) //� ������ ������ �� �������
    {
        if (other.CompareTag("Column"))
        {
            scoreText.text = $"����: {++score}"; //++score �� ������� ���������� 
        }
    }
    public void Death(Collision collision) //Collision ������ ������� ��������� ������������, ����� �� ���� �������� ������, � ������� ��������� ������������
    {
        if (collision.gameObject.CompareTag("Death"))
        {
            enabled = false; //��������� ������ player
            gameOver_Screen.SetActive(true);
            colSpawn.enabled = false;
        }
    }
}
