using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueBadger : MonoBehaviour
{
   
    public GameObject textbadg;
    public TextMeshProUGUI textComponent;
    public string[] linesbadg;
    public float textSpeed;
    public GameObject UI;
    public GameObject Button;
    private int index;

    // Start is called before the first frame update
    public void Start()
    {
      
        if (textbadg.activeInHierarchy)
        {
            textComponent.text = string.Empty;
            StartDialogue();
            
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == linesbadg[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = linesbadg[index];
            }
        }
    }

    public void StartDialogue()
    {
        UI.SetActive(false);    

        index = 0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine()
    {
        foreach (char c in linesbadg[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    void NextLine()
    {
        if (index < linesbadg.Length - 1) 
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());

        }
         else 
        {
            
           
             textbadg.SetActive(false);
            UI.SetActive(true);
            Button.SetActive(false);
        }
    }
}
