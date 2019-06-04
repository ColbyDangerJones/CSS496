using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public int numCapVertices = 0;          //Square ends since line is so thin.
    public GameObject gameObject1;          // Reference to the first GameObject
    public GameObject gameObject2;          // Reference to the second GameObject
    public Material mat;

    private LineRenderer line;
        
        // Line Renderer
                                                         // Start is called before the first frame update

    [System.Obsolete]
    void Start()
    {
        // Add a Line Renderer to the GameObject
        //line = this.gameObject.AddComponent<LineRenderer>();
        // Set the width of the Line Renderer
        line = this.gameObject.AddComponent<LineRenderer>();
        line.material = new Material(Shader.Find("Sprites/Default"));

        line.SetWidth(0.01F, 0.01F);

        // A simple 2 color gradient with a fixed alpha of 1.0f.
        float alpha = 1.0f;
        Gradient gradient = new Gradient();
        gradient.SetKeys(
            new GradientColorKey[] { new GradientColorKey(Color.magenta, 0.0f), new GradientColorKey(Color.cyan, 1.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0.0f), new GradientAlphaKey(alpha, 1.0f) });
        line.colorGradient = gradient;

        //line.SetColors(Color.cyan, Color.green);
        
        // Set the number of vertex fo the Line Renderer
        line.SetVertexCount(2);
    }

    // Update is called once per frame
    void Update()
    {

        line.numCapVertices = numCapVertices;

        // Check if the GameObjects are not null
        if (gameObject1 != null && gameObject2 != null)
        {
            // Update position of the two vertex of the Line Renderer
            line.SetPosition(0, gameObject1.transform.position);
            line.SetPosition(1, gameObject2.transform.position);
        }
    }
}
