using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendController : MonoBehaviour
{
    public DialogClass dialog;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        TriggerDialogue();
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }
}
