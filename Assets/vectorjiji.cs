using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class vectorjiji
{

    [SerializeField] float X, Y; 

    public vectorjiji(float x, float y)
    {
        this.X = x;
        this.Y = y;
    }

    public void Draw(Color color)
    {
        Debug.DrawLine(Vector3.zero, new Vector3(X, Y), color);
    }

    public void Draw(vectorjiji vecInicio, Color color)
    {
        Debug.DrawLine(new Vector3(vecInicio.X,vecInicio.Y), new Vector3(X+vecInicio.X,Y+vecInicio.Y), color);
    }

    public vectorjiji Suma(vectorjiji sumado)
    {
        float tmpX = X + sumado.X;
        float tmpY = Y + sumado.Y;

        return new vectorjiji(tmpX, tmpY);
    }

    public static vectorjiji operator +(vectorjiji a, vectorjiji b)
    {
        return new vectorjiji(a.X + b.X, a.Y + b.Y);
    }

    public static vectorjiji operator -(vectorjiji a, vectorjiji b)
    {
        return new vectorjiji(a.X - b.X, a.Y - b.Y);
    }

    public vectorjiji Resta(vectorjiji restado)
    {
        float tmpX = X - restado.X;
        float tmpY = Y - restado.Y;

        return new vectorjiji(tmpX, tmpY);
    }

    public override string ToString()
    {
        return ("("+X + ", " + Y + ")");
    }

    public vectorjiji Escalar(float escalar)
    {
        return new vectorjiji(X * escalar, Y * escalar);
    }

    public static vectorjiji operator *(vectorjiji a, float b)
    {
        return new vectorjiji(a.X * b, a.Y * b);
    }

    public float Magnitud()
    {
        return Mathf.Sqrt(Mathf.Pow(X,2)+Mathf.Pow(Y,2));
    }

    public vectorjiji Normalizar()
    {
        return new vectorjiji(X / Magnitud(), Y / Magnitud());
    }

    public vectorjiji Lerp(vectorjiji b, float k)
    {
        return Suma(b.Resta(this).Escalar(k));
    }
    
}
