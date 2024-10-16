using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CircleRenderer : MonoBehaviour
{
    private LineRenderer lineRenderer;
    public int segments = 100; // Dairenin segment sayýsý
    public float radius;  // Dairenin yarýçapý

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = segments + 1; // Segment sayýsýný ayarla
        DrawCircle(); // Daireyi çiz
    }

    void DrawCircle()
    {
        float angle = 0f; // Açýyý sýfýrdan baþlat
        for (int i = 0; i <= segments; i++)
        {
            float x = Mathf.Cos(angle) * radius; // X pozisyonunu hesapla
            float z = Mathf.Sin(angle) * radius; // Z pozisyonunu hesapla
            lineRenderer.SetPosition(i, new Vector3(x, 0, z)); // Noktayý ayarla
            angle += (Mathf.PI * 2) / segments; // Açýyý güncelle
        }
        lineRenderer.loop = true; // Dairenin kapalý olmasýný saðla
    }
}

