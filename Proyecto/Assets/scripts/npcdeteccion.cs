using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcdeteccion : MonoBehaviour
{
    public Dialogo dialogo;
    public GameObject theTrigger;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject == theTrigger)
            FindObjectOfType<DialogosGlobal>().StartDialogue(dialogo);
    }
}