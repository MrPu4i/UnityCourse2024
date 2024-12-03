using UnityEngine;
using UnityEngine.SceneManagement;

public class rotate : MonoBehaviour
{
    //каждую секунду поворачивать по y
    [SerializeField] private float rotationSpeed = 1f;
    void Start()
    {
        //DontDestroyOnLoad(this);
        //у каждого объекта ставить эту марку сложно, поэтому по другому сделаем
        //лучше когда есть промежуточная сцена, что-то общее у всех
    }

    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.UnloadSceneAsync(1); // мы могли подождать, перед тем как делать что-то следующее. Асинхронно. Когда между
            //сценами загрузка. Доружаем основную сцену параллельно. Когда догрузится - сцена заменится на основную.
            SceneManager.LoadScene(1, LoadSceneMode.Additive);
        }
    }
}
