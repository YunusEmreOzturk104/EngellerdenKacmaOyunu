using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class hak : MonoBehaviour
{
    public static int kalanHak = 3;
    public GameObject bitisPaneli;
    public TextMeshProUGUI hakYazisi;
    void Update()
    {
        hakYazisi.text = "Hak: " + kalanHak.ToString();
        if (kalanHak == 0)
        {
            bitisPaneli.SetActive(true);//aktifliðini ac demek
            Time.timeScale = 0;//oyunun hizini sifir yap demek
        }
    }
}
