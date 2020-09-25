using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kaisetu : MonoBehaviour
{
    //解説画像の変数化
    [SerializeField] GameObject pirafukaisetu;
    [SerializeField] GameObject pizakaisetu;
    [SerializeField] GameObject pasutakaisetu;
    [SerializeField] GameObject susikaisetu;
    [SerializeField] GameObject syurinnpukaisetu;
    [SerializeField] GameObject ebifuraikaisetu;
    [SerializeField] GameObject tenndonnkaisetu;
    [SerializeField] GameObject kusikaisetu;
    [SerializeField] GameObject guratannkaisetu;
    [SerializeField] GameObject paeriakaisetu;
    [SerializeField] GameObject ebitennkaisetu;
    [SerializeField] GameObject sasimikaisetu;
    [SerializeField] GameObject saradakaisetu;
    [SerializeField] GameObject kyodaiebikaisetu;
    [SerializeField] GameObject gurirukaisetu;

    [SerializeField] GameObject modoru;

    // Start is called before the first frame update
    void Start()
    {
        //戻るボタン呼び出し
        BackToMenu();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SlectebipirafuDescription()
    {
        //ピラフ解説
        pirafukaisetu.SetActive(true);
        modoru.SetActive(true);
    }

    public void SlectpizaDescription()
    {
        //ピザ解説
        pizakaisetu.SetActive(true);
        modoru.SetActive(true);
    }

    public void SlectpasutaDescription()
    {
        //パスタ解説
        pasutakaisetu.SetActive(true);
        modoru.SetActive(true);
    }

    public void SlectsusiDescription()
    {
        //寿司解説
        susikaisetu.SetActive(true);
        modoru.SetActive(true);
    }

    public void SlectsyurinnpuDescription()
    {
        //ガーリックシュリンプ解説
        syurinnpukaisetu.SetActive(true);
        modoru.SetActive(true);
    }

    public void SlectebifuraiDescription()
    {
        //エビフライ解説
        ebifuraikaisetu.SetActive(true);
        modoru.SetActive(true);
    }

    public void SlecttenndonnDescription()
    {
        //天丼解説
        tenndonnkaisetu.SetActive(true);
        modoru.SetActive(true);
    }

    public void SlectkusiDescription()
    {
        //串焼き解説
        kusikaisetu.SetActive(true);
        modoru.SetActive(true);
    }

    public void SlectguratannDescription()
    {
        //グラタン解説
        guratannkaisetu.SetActive(true);
        modoru.SetActive(true);
    }

    public void SlectpaeriaDescription()
    {
        //パエリア解説
        paeriakaisetu.SetActive(true);
        modoru.SetActive(true);
    }


    public void SlectebitennDescription()
    {
        //エビ天解説
        ebitennkaisetu.SetActive(true);
        modoru.SetActive(true);
    }

    public void SlectsasimiDescription()
    {
        //刺身解説
        sasimikaisetu.SetActive(true);
        modoru.SetActive(true);
    }

    public void SlectsaradaDescription()
    {
        //サラダ解説
        saradakaisetu.SetActive(true);
        modoru.SetActive(true);
    }

    public void SlectkyodaiebiDescription()
    {
        //巨大エビ解説
        kyodaiebikaisetu.SetActive(true);
        modoru.SetActive(true);
    }

    public void SlectguriruDescription()
    {
        //グリル解説
        gurirukaisetu.SetActive(true);
        modoru.SetActive(true);
    }

    public void BackToMenu()
    {
        pirafukaisetu.SetActive(false);
        pizakaisetu.SetActive(false);
        pasutakaisetu.SetActive(false);
        susikaisetu.SetActive(false);
        syurinnpukaisetu.SetActive(false);
        ebifuraikaisetu.SetActive(false);
        tenndonnkaisetu.SetActive(false);
        kusikaisetu.SetActive(false);
        guratannkaisetu.SetActive(false);
        paeriakaisetu.SetActive(false);
        ebitennkaisetu.SetActive(false);
        sasimikaisetu.SetActive(false);
        saradakaisetu.SetActive(false);
        kyodaiebikaisetu.SetActive(false);
        gurirukaisetu.SetActive(false);

        modoru.SetActive(false);
    }

}
