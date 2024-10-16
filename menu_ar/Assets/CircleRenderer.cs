using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CircleRenderer : MonoBehaviour
{
    private LineRenderer lineRenderer;
    public int segments = 100; // Dairenin segment say�s�
    public float radius;  // Dairenin yar��ap�

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = segments + 1; // Segment say�s�n� ayarla
        DrawCircle(); // Daireyi �iz
    }

    void DrawCircle()
    {
        float angle = 0f; // A��y� s�f�rdan ba�lat
        for (int i = 0; i <= segments; i++)
        {
            float x = Mathf.Cos(angle) * radius; // X pozisyonunu hesapla
            float z = Mathf.Sin(angle) * radius; // Z pozisyonunu hesapla
            lineRenderer.SetPosition(i, new Vector3(x, 0, z)); // Noktay� ayarla
            angle += (Mathf.PI * 2) / segments; // A��y� g�ncelle
        }
        lineRenderer.loop = true; // Dairenin kapal� olmas�n� sa�la
    }
}

