using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Valve.VR;

/*
 * Attach is a functionality of the PointerType tagged objects.
 * Applies the players hand (both)
 * Uses TextMeshPro Components to display and move any data between Nodes
 * Instantiates FixedJoint components between PointerType and NodeType tags on collision
 * Works in conjunction with Interactable.cs & Hand.cs to remove FixedJoint components of PointerTypes on pickup (Pinch && Grip)
 */
public class Attach : MonoBehaviour
{
    public TextMeshPro TMPInput;

    Valve.VR.InteractionSystem.Hand currentHand;// = new Valve.VR.InteractionSystem.Hand();
    AudioSource attachSound;

    //bool hasJoint = false;

    // Start is called before the first frame update
    void Start()
    { 
        currentHand = FindObjectOfType<Valve.VR.InteractionSystem.Hand>();
        attachSound = GetComponent<AudioSource>();
    }

    /*
     * Objects with this script will attach at any point when coming into contact with a "NodeType" tagged object.
     * Upon collision, creates a FixedJoint between the two objects Rigidbodies, and triggers a small vibration
     * 
     * Optional bool hasJoint 
     */
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody>() != null && //Checking for the other objects rigidbody
            collision.gameObject.tag == "NodeType")// && hasJoint == false) //&& Checking for Node tag
        {
            FixedJoint fj = gameObject.AddComponent<FixedJoint>(); //initialize FixedJoint
            fj.connectedBody = collision.gameObject.GetComponent<Rigidbody>(); //Attach FixedJoint to other rigidbody

            TextMeshPro otherText = collision.transform.Find("dataText").GetComponent<TextMeshPro>();
            TMPInput.text = otherText.text; //Change the text displayed on the TMPInput object

            currentHand.TriggerHapticPulse(10000);
            attachSound.Play();
            //hasJoint = true;
        }
    }

    /*
     * OnCollisionStay finds the correct input from the node being collided with, and updates the text on its parents node.
     */
    //private void OnCollisionStay(Collision collision)
    //{
    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    if(TMPInput.text != null)
    //    {
    //        TMPInput.text = "NULL";
    //        hasJoint = false;
    //        Debug.Log("OnCollisionExit was called");
    //    }

    //}
}
