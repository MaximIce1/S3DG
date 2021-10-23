using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject[] firstGroup;
    public GameObject[] secondGroup;
    //массивы групп блоков
    public Button button;
    //сама кнопка
    public Material normal;
    public Material transparent;
    //материалы
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MoveX") || other.CompareTag("Player") || other.CompareTag("MoveY"))
        {
            foreach (GameObject first in firstGroup)
            {
                first.GetComponent<Renderer>().material = normal;
                first.GetComponent<Collider>().isTrigger = false;
            }
            foreach (GameObject second in secondGroup)
            {
                second.GetComponent<Renderer>().material = transparent;
                second.GetComponent<Collider>().isTrigger = true;
            }
            GetComponent<Renderer>().material = transparent;
            button.GetComponent<Renderer>().material = normal;
        }
    }
}

   