 using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using UnityEngine;

public class ActivarGameOver : MonoBehaviour
{
    public GameObject camaraGameOver;
    // Start is called before the first frame update
    void Start()
    {
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");
    }

    void PersonajeHaMuerto(Notification notificacion) {
        camaraGameOver.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
