using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/* Attaches floppy disks to NodeType objects
 * 
 * Transfers the text value to the Node
 * 
 * Destroys the floppy disk GameObject
 * 
 * Activates a mesh attached to each NodeType object
 * 
 */
public class AttachFloppy : MonoBehaviour
{
    public TextMeshPro Data;

    public int BreakForce = 5;
    public int BreakTorque = 5;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody>() != null && collision.gameObject.tag == "NodeType")
        {
            TextMeshPro other = collision.transform.Find("dataText").GetComponent<TextMeshPro>();
            other.text = this.Data.text; //collision.gameObject.GetComponent<TextMesh>().name;
            Destroy(gameObject);
            collision.transform.Find("FloppyDiskMesh").gameObject.SetActive(true);
        }
    }

    /* 
     * On trigger version that physically moves the floppy disk from hand to the location
     * 
     * Unused because of working issues
     */
    //private void OnTriggerEnter(Collider other)
    //{
    //    TextMeshPro NodeData = other.transform.Find("dataText").GetComponent<TextMeshPro>();
    //    NodeData.text = this.Data.text; //collision.gameObject.GetComponent<TextMesh>().name;
    //    Destroy(this);
    //    other.transform.Find("FloppyDiskMesh").GetComponent<GameObject>().SetActive(true);
    //    //if (other.GetComponent<Rigidbody>() != null)// && !hasJoint)
    //    //{
    //    //    //gameObject.AddComponent<FixedJoint>();
    //    //    //gameObject.GetComponent<FixedJoint>().connectedBody = other.attachedRigidbody;

    //    //}
    //}
}
