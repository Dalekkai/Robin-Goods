using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IntroNef : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;
    public GameObject dialogueBox;
    public GameObject player;

    public void Start ()
    {
            StartCoroutine(SecondCoroutine());
   
    }
    private void Update()
    {
        player.GetComponent<PlayerMovement>().enabled = false;
        player.GetComponent<PlayerAttack>().enabled = false;

        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }

    IEnumerator Type()
    {
        yield return new WaitForSeconds(1.1f);

        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    IEnumerator SecondCoroutine()
    {
        yield return new WaitForSeconds(5);
        StartCoroutine(Type());
    }
    public void NextSentence()
    {
        continueButton.SetActive(false);

        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());

        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
            dialogueBox.SetActive(false);
        }
    }

}
