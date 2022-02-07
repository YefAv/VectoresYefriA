using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class elotro : MonoBehaviour
{
    [SerializeField]vectorjiji uno = new vectorjiji(-1, 3);

    [SerializeField]vectorjiji dos = new vectorjiji(2, 2);


    private vectorjiji resta;

    private vectorjiji suma;

    [SerializeField] [Range(0, 1)] private float tamaño;
    

    // Update is called once per frame
    void Update()
    {
        uno.Draw(Color.green);
        dos.Draw(Color.red);
        
        resta = dos.Resta(uno).Escalar(tamaño);

        uno.Lerp(dos, tamaño).Draw(Color.magenta);


        

        //resta.Draw(uno,Color.yellow);

    }
}
