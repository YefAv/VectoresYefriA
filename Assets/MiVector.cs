using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MiVector
{

    [SerializeField] float X, Y; 

    public MiVector(float x, float y)
    {
        this.X = x;
        this.Y = y;
    }

    public void Draw(Color color)
    {
        Debug.DrawLine(Vector3.zero, new Vector3(X, Y), color);
    }

    public void Draw(MiVector vecInicio, Color color)
    {
        Debug.DrawLine(new Vector3(vecInicio.X,vecInicio.Y), new Vector3(X+vecInicio.X,Y+vecInicio.Y), color);
    }

    public MiVector Suma(MiVector sumado)
    {
        float tmpX = X + sumado.X;
        float tmpY = Y + sumado.Y;

        return new MiVector(tmpX, tmpY);
    }

    public static MiVector operator +(MiVector a, MiVector b)
    {
        return new MiVector(a.X + b.X, a.Y + b.Y);
    }

    public static MiVector operator -(MiVector a, MiVector b)
    {
        return new MiVector(a.X - b.X, a.Y - b.Y);
    }

    public MiVector Resta(MiVector restado)
    {
        float tmpX = X - restado.X;
        float tmpY = Y - restado.Y;

        return new MiVector(tmpX, tmpY);
    }

    public override string ToString()
    {
        return ("("+X + ", " + Y + ")");
    }

    public MiVector Escalar(float escalar)
    {
        return new MiVector(X * escalar, Y * escalar);
    }

    public static MiVector operator *(MiVector a, float b)
    {
        return new MiVector(a.X * b, a.Y * b);
    }

    public float Magnitud()
    {
        return Mathf.Sqrt(Mathf.Pow(X,2)+Mathf.Pow(Y,2));
    }

    public MiVector Normalizar()
    {
        return new MiVector(X / Magnitud(), Y / Magnitud());
    }

    public MiVector Lerp(MiVector b, float k)
    {
        return Suma(b.Resta(this).Escalar(k));
    }
    
}
