using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveButton : MonoBehaviour
{
    public void pressLeave()
    {
        DialogueManager.Instance.ExitDialogueMode();
    }
}
