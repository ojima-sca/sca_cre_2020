using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Siruetto : MonoBehaviour
{

    private GameObject PirafuSilhouette;
    private GameObject PizaSilhouette;
    private GameObject PasutaSilhouette;
    private GameObject SusiSilhouette;
    private GameObject SyurinnpuSilhouette;
    private GameObject TenndonnSilhouette;
    private GameObject KusiSilhouette;
    private GameObject GuratannSilhouette;
    private GameObject PaeriaSilhouette;
    private GameObject EbitennSilhouette;
    private GameObject EbifuraiSilhouette;
    private GameObject SasimiSilhouette;
    private GameObject SaradaSilhouette;
    private GameObject KyodaiSilhouette;
    private GameObject GuriruSilhouette;

    // Start is called before the first frame update
    void Start()
    {
        int rizaruto = Result_EbiScroll.getPicu_UP;

        if (rizaruto == 0)
        {
            PirafuSilhouette.SetActive(false);
        }else if (rizaruto == 1)
        {
            PizaSilhouette.SetActive(false);
        }
        else if (rizaruto == 2)
        {
            PasutaSilhouette.SetActive(false);
        }
        else if (rizaruto == 3)
        {
            SusiSilhouette.SetActive(false);
        }
        else if (rizaruto == 4)
        {
            SyurinnpuSilhouette.SetActive(false);
        }
        else if (rizaruto == 5)
        {
            EbifuraiSilhouette.SetActive(false);
        }
        else if (rizaruto == 6)
        {
            TenndonnSilhouette.SetActive(false);
        }
        else if (rizaruto == 7)
        {
            KusiSilhouette.SetActive(false);
        }
        else if (rizaruto == 8)
        {
            GuratannSilhouette.SetActive(false);
        }
        else if (rizaruto == 9)
        {
            PaeriaSilhouette.SetActive(false);
        }
        else if (rizaruto == 10)
        {
            EbitennSilhouette.SetActive(false);
        }
        else if (rizaruto == 11)
        {
            SasimiSilhouette.SetActive(false);
        }
        else if (rizaruto == 12)
        {
            SaradaSilhouette.SetActive(false);
        }
        else if (rizaruto == 13)
        {
            KyodaiSilhouette.SetActive(false);
        }
        else if (rizaruto == 14)
        {
            GuriruSilhouette.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
