using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class engeller : MonoBehaviour
{
    private static int skor;
    public TextMeshProUGUI skorYazisi,bitisYazisi;
    private void Start()
    {
        skor = 0;
    }
    private void Update()
    {
        skorYazisi.text = skor.ToString();
        bitisYazisi.text = "Oyun Bitti! \n Skor : " + skor.ToString();
    }
    private void OnCollisionEnter2D(Collision2D temas)
    {
        float xPozisyonu = Random.Range(-5f, +5f);
        float yPozisyonu = Random.Range(6.5f, 15f);
        if (temas.gameObject.tag == "Kontrol_Cubugu")
        {
            transform.position = new Vector2(xPozisyonu, yPozisyonu);
            skor += Random.Range(8, 14);  
        }
        else if (temas.gameObject.tag=="Karakter")
        {
            transform.position = new Vector2(xPozisyonu, yPozisyonu);
            hak.kalanHak--;
        }
    }
}
