using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class MiCodigo : MonoBehaviour
{
    [SerializeField]MiVector uno = new MiVector(-1, 3);

    [SerializeField]MiVector dos = new MiVector(2, 2);

    private MiVector resta1, resta2, suma1, suma2, escalar1, escalar2;

    [SerializeField] [Range(0, 1)] private float tamaño;
    

    // Update is called once per frame
    void Update()
    {
        //Draw

        uno.Draw(Color.green);
        dos.Draw(Color.cyan);

        //Draw con otro origen
        uno.Draw(new MiVector(1, -5), Color.white);

        //Lerp
        uno.Lerp(dos, tamaño).Draw(Color.magenta);

        //Resta
        Debug.Log("Restas");

        resta1 = uno - dos;
        Debug.Log(resta1);

        resta2 = uno.Resta(dos);
        Debug.Log(resta2);

        //Suma
        Debug.Log("Sumas");
        suma1 = uno + dos;
        Debug.Log(suma1);

        suma2 = uno.Suma(dos);
        Debug.Log(suma2);

        //Escalar
        Debug.Log("Escalar");
        escalar1 = uno * 2;
        Debug.Log(escalar1);

        escalar2 = uno.Escalar(2);
        Debug.Log(escalar2);

        //Magnitud
        Debug.Log("Magnitud");
        Debug.Log(escalar1.Magnitud());


        //Normalizar
        Debug.Log("Normalizar");
        Debug.Log(escalar1.Normalizar().Magnitud());


    }
}
