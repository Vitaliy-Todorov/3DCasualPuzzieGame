using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : Transparent
{
    public bool off;
    private void OnTriggerEnter(Collider other)
    {
        if (off) {
            Switching();
        }
    }
}
