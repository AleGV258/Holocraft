using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarModelo : MonoBehaviour
{
    public GameObject planeta;
    public GameObject casa;
    // public GameObject rick;
    // public GameObject shrek;
    // public GameObject spiderman;

    float contadorCambiarModelo = 0; 
    int modeloMostrado = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        contadorCambiarModelo += Time.deltaTime;

        if(contadorCambiarModelo >= 10.0f){ // Segundos que tarda en cambiarse
            switch(modeloMostrado)
            {
                case 1:
                    planeta.SetActive(true);
                    casa.SetActive(false);
                    // rick.SetActive(false);
                    // shrek.SetActive(false);
                    // spiderman.SetActive(false);
                    modeloMostrado = 2;
                    break;
                case 2:
                    planeta.SetActive(false);
                    casa.SetActive(true);
                    // rick.SetActive(false);
                    // shrek.SetActive(false);
                    // spiderman.SetActive(false);
                    modeloMostrado = 1;
                    break;
                // case 3:
                //     planeta.SetActive(false);
                //     casa.SetActive(false);
                //     rick.SetActive(true);
                //     shrek.SetActive(false);
                //     spiderman.SetActive(false);
                //     modeloMostrado = 4;
                //     break;
                // case 4:
                //     planeta.SetActive(false);
                //     casa.SetActive(false);
                //     rick.SetActive(false);
                //     shrek.SetActive(true);
                //     spiderman.SetActive(false);
                //     modeloMostrado = 5;
                //     break;
                // case 5:
                //     planeta.SetActive(false);
                //     casa.SetActive(false);
                //     rick.SetActive(false);
                //     shrek.SetActive(false);
                //     spiderman.SetActive(true);
                //     modeloMostrado = 1;
                //     break;
            }
            contadorCambiarModelo = 0;
        }



    }
}
