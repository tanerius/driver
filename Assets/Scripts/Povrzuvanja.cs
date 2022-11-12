using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Povrzuvanja : MonoBehaviour
{
    [Range(0, 10)]
    public int PrvBroj;

    [Range(0, 50)]
    public int VtorBroj;

    public int Resultat;

    public int AvtomatiziranRezultat;

    private void Update()
    {
        Resultat = Zbir(PrvBroj, VtorBroj);
    }

    int Zbir(int x, int y)
    {
        return x + y;
    }

    public void AutoZbir()
    {
        AvtomatiziranRezultat = PrvBroj + VtorBroj;
    }
}
