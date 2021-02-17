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
        //foreach - for. �������� �� �� ���� ������ � ��������� � � ��������� ��������� ��� �� ���������
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
        //�� ���� ������� ���� ������ �� ����������
        buttonNormal.GetComponent<Renderer>().material = transparent;
        buttonTransparent.GetComponent<Renderer>().material = normal;
    }
}
