using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueBees : MonoBehaviour
{

    public GameObject textbee;
    public TextMeshProUGUI textComponent;
    public string[] linesbee;
    public float textSpeed;
    public GameObject UI;
    public GameObject Button;
    public GameObject Bees;
    private int index;

    // Start is called before the first frame update
    public void Start()
    {
        if (textbee.activeInHierarchy)
        {
            textComponent.text = string.Empty;
            StartDialogue();

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (textbee.activeInHierarchy)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (textComponent.text == linesbee[index])
                {
                    NextLine();
                }
                else
                {
                    StopAllCoroutines();
                    textComponent.text = linesbee[index];
                }
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
        foreach (char c in linesbee[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    void NextLine()
    {
        if (index < linesbee.Length - 1) 
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());

        }
         else 
        {
            
           
            textbee.SetActive(false);
            UI.SetActive(true);
            Button.SetActive(false);
            Bees.SetActive(false);
        }
    }
}
