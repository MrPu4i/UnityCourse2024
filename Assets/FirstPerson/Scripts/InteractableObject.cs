using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    // ������������� ��� ������� ��� ���� ��������� ��������

    [SerializeField] protected bool interactable = true;
    //�� ����� ����������� ������ ��� ������� �������, � ���� ���� ������� �������
    [SerializeField] protected UnityEvent interacted; //��� �������, ��� ����� �������� ��� ������

    private void Awake() //���������� ����� �������
    {
        if (interactable)
        {
            //����� ��������� ������ �� ������ ����
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
        //��� ���������� ����� ������������    
        //����������� �� ������ ������� ������ ������ ����

        interacted?.Invoke(); //Invoke �������� ��� ������, ������� ��������� � ���� �������
    }

}
