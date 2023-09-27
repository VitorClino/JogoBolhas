using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vida : MonoBehaviour
{
    int vida= 3;
    public Canvas canvas;
    public Text m_vida;

    void OnEnable()
    {
        InvokeRepeating("Dano", 0.1f, 0.2f);
    }

    void OnTriggerEnter(Collider other)
    {
        vida--;
        m_vida.text = $"Vida = {vida}";
        Destroy(other.gameObject);
    }
    
    public void Dano()
    {
        if (vida <= 0 )
        {
            canvas.gameObject.SetActive(true);
            Time.timeScale =0;
        }
    }
    
}
