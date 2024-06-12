using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public GameObject nextRabbit;
    public GameObject prevRabbit;
    public GameObject text;
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public GameObject UI;
    public GameObject Button;
    private int index;

    // Start is called before the first frame update
    public void Start()
    {
      
        if (text.activeInHierarchy)
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
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
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
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    void NextLine()
    {
        if (index < lines.Length - 1) 
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());

        }
         else 
        {
            
            prevRabbit.SetActive(false);
            nextRabbit.SetActive(true); 
            text.SetActive(false);
            UI.SetActive(true);
            Button.SetActive(false);
        }
    }
}
