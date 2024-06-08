using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueStart : MonoBehaviour
{
  public GameObject dialogueText;

  public void Starter()
  {
    dialogueText.SetActive(true);
  }
  
  
}
