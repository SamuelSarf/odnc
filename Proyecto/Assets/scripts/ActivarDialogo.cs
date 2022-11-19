using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarDialogo : MonoBehaviour
{
    public Dialogo dialogo;

    public void IniciarDialogo()
    {
        FindObjectOfType<DialogosGlobal>().StartDialogue(dialogo);
    }
}
