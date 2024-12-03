using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Manager : MonoBehaviour
{
    [SerializeField] private ColumnSpawner colSpawn;
    [SerializeField] private Player player;
    [SerializeField] private TextMeshProUGUI scoreText; //TextMeshPro триденщный который можно расплогать на сцене, c UGUI это интерфейс юнити
    [SerializeField] private GameObject gameOver_Screen;

    private int score = 0;
    public void Restart()
    {
        //указать сцену которую мы хотим загрузить
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GetScore(Collider other) //в момент выхода из колонны
    {
        if (other.CompareTag("Column"))
        {
            scoreText.text = $"—чЄт: {++score}"; //++score тк сначала выполнитс€ 
        }
    }
    public void Death(Collision collision) //Collision объект который описывает столкновение, через неЄ надо получить объект, с которым произошло столкновение
    {
        if (collision.gameObject.CompareTag("Death"))
        {
            enabled = false; //отключаем скрипт player
            gameOver_Screen.SetActive(true);
            colSpawn.enabled = false;
        }
    }
}
