using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProstiDvizenja : MonoBehaviour
{
    public GameObject Kocka;
    private float vreme;
    public float segasnaPozicija = 0;

    // Update is called once per frame
    void Update()
    {
        if (segasnaPozicija >= 3)
        {
            Kocka.transform.position = new Vector3(3, 0, 0);
        }
        else
        {
            // Linearno dvizenje - ne usporuva dvizenjeto so vreme
            segasnaPozicija = segasnaPozicija + Time.deltaTime;
            
            // So interpolacija - se usporuve so vreme dvizenjeto
            //segasnaPozicija = Mathf.Lerp(segasnaPozicija, 3, Time.deltaTime);
            
            // So ova se menuva pozicijata na objectot 
            // (za objekti koi sto nemaat Rigidbody)
            Kocka.transform.position = new Vector3(segasnaPozicija, 0, 0);
        }
    }
}
