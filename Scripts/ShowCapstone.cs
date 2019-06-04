using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Small script to activate the plane which holds the capstone poster
 * 
 * Script is separate becaause textMeshPro objects don't handle .png files well, so the file is applied to a 3D plane.
 */
public class ShowCapstone : MonoBehaviour
{
    public GameObject Display;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody>() != null && collision.gameObject.tag == "ScreenNode")
        {

            Display.SetActive(true);

            Destroy(gameObject);

            collision.transform.Find("FloppyDiskMesh").gameObject.SetActive(true);
        }
    }
}
