using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterHareketi : MonoBehaviour
{
    public float hareketHizi;
    void Start()
    {
        
    }
    void Update()
    {
        float hiz = hareketHizi * Input.GetAxis("Horizontal");
        transform.Translate(hiz * Time.deltaTime, 0, 0);//harekete çevirir delta time demek bütün cihazlarda ayný hýzla hareket etmesini saðlar
    }
}
