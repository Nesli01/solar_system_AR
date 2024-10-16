using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawLine : MonoBehaviour
{
    public LineRenderer lineRenderer; // Takip edilecek Line Renderer
    public float speed; // Hareket h�z�
    private int currentPoint = 0; // �u anki hedef nokta indeksi

    void Update()
    {
        if (lineRenderer.positionCount > 0)
        {
            Vector3 hedefPozisyon = lineRenderer.GetPosition(currentPoint);

            // Nesneyi bu noktaya do�ru hareket ettir
            transform.position = Vector3.MoveTowards(transform.position, hedefPozisyon, speed * Time.deltaTime);

            // E�er hedef noktaya ula�t�ysa bir sonraki noktaya ge�
            if (Vector3.Distance(transform.position, hedefPozisyon) < 0.1f)
            {
                currentPoint = (currentPoint + 1) % lineRenderer.positionCount; // Dairede sonsuz d�ng�
            }
        }
    }
}
