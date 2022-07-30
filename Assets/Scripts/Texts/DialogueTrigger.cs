using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueTrigger : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;
    public GameObject dialogueBox;
    public GameObject player;
    public GameObject triggerText;
    public GameObject holdPlayer;

    private void Start()
    {
        StartCoroutine(TextRoutine());
    }
    private void Update()
    {
        player.GetComponent<PlayerMovement>().enabled = false;
        player.GetComponent<PlayerAttack>().enabled = false;
        player.GetComponent<PlayerController>().enabled = false;

        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }

    public IEnumerator TextRoutine()
    {
        yield return new WaitForSeconds(1);

        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);

        if(index < sentences.Length -1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(TextRoutine());

        } else {
            textDisplay.text = "";
            continueButton.SetActive(false);
            dialogueBox.SetActive(false);
            player.GetComponent<PlayerMovement>().enabled = true;
            player.GetComponent<PlayerController>().enabled = true;
            player.GetComponent<PlayerAttack>().enabled = true;
            triggerText.SetActive(false);
            holdPlayer.SetActive(false);
        }
    }

}
