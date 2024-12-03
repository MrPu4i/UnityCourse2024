using UnityEngine;

public class Deleter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Column")) //сравнивать теги через == нельзя, плохо реализованно, надо CompareTag использовать
        {
            Destroy(other.gameObject);
        }
    }
}
