using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendController : MonoBehaviour
{
    public DialogClass dialog;
    private bool triggered = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!triggered)
        {
            triggered = true;
            TriggerDialogue();
        }
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }
}
