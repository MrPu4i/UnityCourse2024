using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    // наследоваться все скрипты для всех остальных объектов

    [SerializeField] protected bool interactable = true;
    //не хотим прописывать скрипт для каждого объекта, в виде поля указать событие
    [SerializeField] protected UnityEvent interacted; //это событие, при каких условиях что делает

    private void Awake() //вызывается перед стартом
    {
        if (interactable)
        {
            //нужно поставить объект на нужный слой
            tag = "Interact";
            gameObject.layer = LayerMask.NameToLayer("Interaction"); // 1 << 8
        }
    }
    public void SetInteractable(bool _interactable)
    {
        this.interactable = _interactable;
        if (interactable)
        {
            tag = "Interact";
        }
        else
        {
            tag = "Untagged";
        }
    }
    public virtual void Interact()
    {
        print("Interact with" + gameObject);
        //что происходит когда интерактимся    
        //виртуальный тк разные объекты делают разные вещи

        interacted?.Invoke(); //Invoke вызывает все методы, которые находятся в этом событии
    }

}
