using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CenterText : MonoBehaviour
{
    private void Start()
    {
        GetComponent<TextMeshPro>().alignment = TextAlignmentOptions.Center;
    }
}
