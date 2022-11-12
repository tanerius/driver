using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IspisiBroj(5);
        long promenliva1 = IspisiBrojSoIzlez(6);
        Debug.Log(promenliva1);
    }

    /// <summary>
    /// TestFunkcija e funkcija bez vlezen parametar koja sto ne vrakja vrednost
    /// </summary>
    void TestFunkcija()
    {
        Debug.Log("Pocnuvam so igrata!");
    }

    /// <summary>
    /// IspisiBroj e funkcija so eden vlezen parametar od tipot CEL broj 
    /// koja sto ne vrakja vrednost (bidejki e void)
    /// </summary>
    void IspisiBroj(int broj)
    {
        int pomnozenBroj = broj * 2;
        Debug.Log(pomnozenBroj);
    }


    /// <summary>
    /// IspisiBrojSoIzlez e funkcija so 
    /// eden vlezen parametar od tipot CEL broj - int
    /// koja sto  vrakja vrednost od tipot ne cel broj - int
    /// </summary>
    int IspisiBrojSoIzlez(int broj)
    {
        int pomnozenBroj = broj * 3;
        return pomnozenBroj;
    }
}
