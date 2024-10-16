using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class planetShow : MonoBehaviour
{
    public GameObject[] planets;
    public GameObject solarsystem;
    public GameObject[] Panel;
    public GameObject[] info;

    private void Start()
    {
        solarsystem.SetActive(false);
        foreach (var planet in planets) 
        {
            planet.SetActive(false);
        }

        foreach (var information in info)
        {
            information.SetActive(false);
        }
        foreach(var panels in Panel)
        {
            panels.SetActive(false);
        }
    }

    public void ShowPlanet(int planetIndex)
    {
        
        foreach (var planet in planets)
        {
            planet.SetActive(false);
        }
        foreach (var information in info)
        {
            information.SetActive(false);
        }
        foreach (var panels in Panel)
        {
            panels.SetActive(false);
        }


        if (planetIndex >= 0 && planetIndex < planets.Length)
        {
            planets[planetIndex].SetActive(true);
            info[planetIndex].SetActive(true);
        }

       
    } 

    public void PanelShow(int panelIndex)
    {
        foreach (var panels in Panel)
        {
            panels.SetActive(false);
        }
        if(panelIndex >= 0 && panelIndex < Panel.Length)
        {
            Panel[panelIndex].SetActive(true);
        }
    }

}
