using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TutorialManager : MonoBehaviour
{
    public GameObject PosterScreen;
    public TextMeshPro TutorialScreen;
    public TextMeshPro InstructionsScreen;

    public GameObject Node1;
    public GameObject Node2;
    public GameObject Node3;

    public string[] Instructions = new string[10];
    private int InstructionIndex;

    //private void Start()
    //{
    //    Instructions[0] = "Welcome to my Capstone, \nPlease insert the large floppy disk on your right into the slot on your left to begin.";
    //    Instructions[1] = "Lesson 1:\n\nThis is a Node.\nTry picking it up.";
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    for (int i = 0; i < InstructionIndex; i++)
    //    {
    //        if(i == InstructionIndex)
    //        {
    //            TutorialScreen.text = Instructions[InstructionIndex];
    //            PosterScreen.transform.Find("CapstonePoster").gameObject.SetActive(true);
    //        }
    //    }
    //}
}
