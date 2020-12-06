using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour
{
    static Material mat;
    // Start is called before the first frame update
    
    static void CreateLineMaterial()
    {
        if (!mat)
        {
            // Unity has a built-in shader that is useful for drawing
            // simple colored things.
            Shader shader = Shader.Find("Hidden/Internal-Colored");
            mat = new Material(shader);
            mat.hideFlags = HideFlags.HideAndDontSave;
            // Turn on alpha blending
            mat.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
            mat.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
            // Turn backface culling off
            mat.SetInt("_Cull", (int)UnityEngine.Rendering.CullMode.Off);
            // Turn off depth writes
            mat.SetInt("_ZWrite", 0);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnPostRender()
    {
        //GL.Clear(true,true,Color.white);
        
        CreateLineMaterial();
        
        GL.PushMatrix();

        mat.SetPass(0);
        
        GL.Begin(GL.LINES);

        GL.Color(Color.blue);

        GL.Vertex3(0, 0, 0);
        
        GL.Vertex3(100,100,0);

        GL.Color(Color.white);
        
        GL.Vertex3(100,100,0);
        
        GL.Vertex3(1,100,100);

        GL.Color(Color.cyan);
        
        GL.Vertex3(1,100,100);
        
        GL.Vertex3(1,0,0);

        GL.End();
        
        GL.PopMatrix();
    }
}
