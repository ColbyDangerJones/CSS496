using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Valve.VR;
using NodeInteractions;

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

    bool hasJoint = false;

    // Start is called before the first frame update
    void Start()
    {
        //TMPInput.text = "NULL";
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
            collision.gameObject.tag == "NodeType") //Checking for Node tag
            //collision.transform.root.parent != transform.root.parent) //Checking that the pointer doesn't belong to it's current node
        {
            FixedJoint fj = gameObject.AddComponent<FixedJoint>(); //initialize FixedJoint
            fj.connectedBody = collision.gameObject.GetComponent<Rigidbody>(); //Attach FixedJoint to other rigidbody

            currentHand.TriggerHapticPulse(10000);

            TextMeshPro otherText = collision.transform.Find("dataText").GetComponent<TextMeshPro>();
            TMPInput.text = otherText.text; //Change the text displayed on the TMPInput object

            attachSound.Play();
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        hasJoint = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        //gameObject.transform.SetParent(null);
        //hasJoint = false;
        //TMPInput.text = "NULL";     
    }
}
