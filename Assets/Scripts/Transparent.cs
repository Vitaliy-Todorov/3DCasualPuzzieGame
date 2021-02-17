using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transparent : MonoBehaviour
{
    [SerializeField]
    private GameObject[] firstGroup;
    [SerializeField]
    private GameObject[] secondGroup;
    [SerializeField]
    private GameObject buttonNormal;
    [SerializeField]
    private GameObject buttonTransparent;
    [SerializeField]
    private Material normal;
    [SerializeField]
    private Material transparent;
    [SerializeField]
    private bool NormalOrTransparent;

    protected void Switching()
    {
        //foreach - for. Проходим по по всей группе и переводим её в состояние видимости или не видимости
        foreach (GameObject first in firstGroup)
        {
            first.GetComponent<Renderer>().material = normal;
            first.GetComponent<Collider>().isTrigger = NormalOrTransparent;
        }
        foreach (GameObject second in secondGroup)
        {
            second.GetComponent<Renderer>().material = transparent;
            second.GetComponent<Collider>().isTrigger = !NormalOrTransparent;
        }
        //По идеи менеяем цвет кнопок на прозрачный
        buttonNormal.GetComponent<Renderer>().material = transparent;
        buttonTransparent.GetComponent<Renderer>().material = normal;
    }
}
