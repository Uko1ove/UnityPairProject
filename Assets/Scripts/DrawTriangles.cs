using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawTriangles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MeshFilter mf = GetComponent<MeshFilter>();
        Mesh mesh = mf.mesh;

        Vector3[] verticles = new Vector3[]
        {

            new Vector3(0.866f, -1f, 0),
            new Vector3(-0.866f, -1f, 0),
            new Vector3(0, 0, 0)
        };

        // triangles, 3 points clockwise determines which side is visible
        int[] triangles = new int[]
        {
            0,1,2
        };

        //UVs - texture
        Vector2[] uvs = new Vector2[]
        {
            new Vector2(1, 1f),
            new Vector2(0, 1f),
            new Vector2(0, 0)
        };

        mesh.Clear();
        mesh.vertices = verticles;
        mesh.triangles = triangles;
        mesh.uv = uvs;
        mesh.Optimize();
        mesh.RecalculateNormals();
    }
}
