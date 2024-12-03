using UnityEngine;

public class ColumnSpawner : MonoBehaviour
{
    [SerializeField] private GameObject column; //gameObject можно любой тип объекта из юнити засунусть
    [SerializeField] private float coolDown = 1;
    [SerializeField] private float upperRange = 2, lowerRange = -2;
    [SerializeField] private float acceleration = 0.1f; //f значит float, надо явно указать
    [SerializeField] private float startSpeed = 10f;

    private float elapsedTime = 0;
    private float currentSpeed = 0;

    private void Start()
    {
        currentSpeed = startSpeed;
    }
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= coolDown)
        {
            GameObject tmp = Instantiate(column, new Vector3(transform.position.x,
                Random.Range(lowerRange, upperRange), transform.position.z), Quaternion.identity, transform);
            tmp.GetComponent<ColumnMove>().speed = startSpeed;
            elapsedTime = 0;
            currentSpeed += acceleration;
        }


    }
}
