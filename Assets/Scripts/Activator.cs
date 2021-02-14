using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    //видимые не видимые группы.
    public GameObject[] firstGroup;
    public GameObject[] secondGroup;
    public Activator button;
    public Material normal;
    public Material transparent;
    public bool canPush;

    private void OnTriggerEnter(Collider other)
    {
        button.canPush = true;
        //проверяем нажатие кнопки. Нужно что бы фигцры не застревани при переходи из прозрачности.
        if (canPush)
        {
            //если коснулся один из кубов
            if (other.CompareTag("Сube") || other.CompareTag("Player"))
            {
                //foreach - for. Проходим по по всей группе и переводим её в состояние видимости или не видимости
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
                //По идеи менеяем цвет кнопок на прозрачный
                GetComponent<Renderer>().material = transparent;
                button.GetComponent<Renderer>().material = normal;
                button.canPush = true;
            }
        }
    }
}
