using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    //позволяет менять приватные поля в юнити
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float jumpForce = 1;
    [SerializeField] private Manager manager;
    void Start()
    {
        //запускается один раз в начале
    }
    void Update() //работает постоянно
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    private void OnTriggerExit(Collider other) //в момент выхода из колонны
    {
        manager.GetScore(other);
    }
    private void OnCollisionEnter(Collision collision) //Collision объект который описывает столкновение, через неё надо получить объект, с которым произошло столкновение
    {
        manager.Death(collision);
    }
}
