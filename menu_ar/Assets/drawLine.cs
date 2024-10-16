using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawLine : MonoBehaviour
{
    public LineRenderer lineRenderer; // Takip edilecek Line Renderer
    public float speed; // Hareket hýzý
    private int currentPoint = 0; // Þu anki hedef nokta indeksi

    void Update()
    {
        if (lineRenderer.positionCount > 0)
        {
            Vector3 hedefPozisyon = lineRenderer.GetPosition(currentPoint);

            // Nesneyi bu noktaya doðru hareket ettir
            transform.position = Vector3.MoveTowards(transform.position, hedefPozisyon, speed * Time.deltaTime);

            // Eðer hedef noktaya ulaþtýysa bir sonraki noktaya geç
            if (Vector3.Distance(transform.position, hedefPozisyon) < 0.1f)
            {
                currentPoint = (currentPoint + 1) % lineRenderer.positionCount; // Dairede sonsuz döngü
            }
        }
    }
}
