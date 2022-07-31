using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueTransitions : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;
    public GameObject dialogueBox;

    public void Start()
    {
        StartCoroutine(TextRoutine());

    }

    private void Update()
    {

        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }

    IEnumerator TextRoutine()
    {
        yield return new WaitForSeconds(1.1f);

        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);

        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(TextRoutine());

        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
            dialogueBox.SetActive(false);
            LevelLoader.LoadNextLevel();
        }
    }

}
