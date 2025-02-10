using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour

    
{
    [SerializeField] GameObject SKnight;
    [SerializeField] GameObject TitleScreen;
    [SerializeField] GameObject Titletext;
    [SerializeField] GameObject Princess;
    [SerializeField] GameObject FPrinncess;
    [SerializeField] GameObject Smonster;
    [SerializeField] GameObject monster;
    [SerializeField] GameObject AKnight;
    [SerializeField] Button ButtonStart;
    [SerializeField] Button FleeButton;
    [SerializeField] Button SeekButton;
    [SerializeField] Button AvoidButton;
    [SerializeField] Button ApproachButton;
    [SerializeField] Button BackButton;
    // Start is called before the first frame update
    void Start()
    {
        SKnight.gameObject.SetActive(false);
        monster.gameObject.SetActive(false);
        FPrinncess.gameObject.SetActive(false);
        Smonster.gameObject.SetActive(false);
        AKnight.gameObject.SetActive(false);
        Princess.gameObject.SetActive(false);
        FleeButton.gameObject.SetActive(false);
        SeekButton.gameObject.SetActive(false);
        AvoidButton.gameObject.SetActive(false);
        BackButton.gameObject.SetActive(false);
        ApproachButton.gameObject.SetActive(false);
        TitleScreen.SetActive(true);
        Titletext.SetActive(true);

        ButtonStart.gameObject.SetActive(true);
    }

    public void pressStart()
    {
        SKnight.gameObject.SetActive(false);
        monster.gameObject.SetActive(false);
        FPrinncess.gameObject.SetActive(false);
        Smonster.gameObject.SetActive(false);
        AKnight.gameObject.SetActive(false);
        Princess.gameObject.SetActive(false);
        FleeButton.gameObject.SetActive(false);
        SeekButton.gameObject.SetActive(false);
        AvoidButton.gameObject.SetActive(false);
        ButtonStart.gameObject.SetActive(false);
        BackButton.gameObject.SetActive(false);
        ApproachButton.gameObject.SetActive(true);
        Titletext.SetActive(false);

        FleeButton.gameObject.SetActive(true);
        SeekButton.gameObject.SetActive(true);
        AvoidButton.gameObject.SetActive(true);
        TitleScreen.SetActive(true);

    }

    public void PressSeek()
    {
        FleeButton.gameObject.SetActive(false);
        SeekButton.gameObject.SetActive(false);
        AvoidButton.gameObject.SetActive(false);
        FPrinncess.gameObject.SetActive(false);
        Smonster.gameObject.SetActive(false);
        AKnight.gameObject.SetActive(false);
        FleeButton.gameObject.SetActive(false);
        SeekButton.gameObject.SetActive(false);
        AvoidButton.gameObject.SetActive(false);
        monster.gameObject.SetActive(false);
        TitleScreen.SetActive(false);
        Titletext.SetActive(false);
        ApproachButton.gameObject.SetActive(false);

        SKnight.gameObject.SetActive(true);
        Princess.gameObject .SetActive(true);
        BackButton.gameObject.SetActive(true);


        SKnight.transform.position = new Vector3(6, -2, 80);
        Princess.transform.position = new Vector3(-4, 4, 80);
    }
    public void PressFlee()
    {
        monster.gameObject.SetActive(false);
        FleeButton.gameObject.SetActive(false);
        SeekButton.gameObject.SetActive(false);
        AvoidButton.gameObject.SetActive(false);
        SKnight.gameObject.SetActive(false);
        AKnight.gameObject.SetActive(false);
        Princess.gameObject.SetActive(false);
        TitleScreen.SetActive(false);
        Titletext.SetActive(false);
        ApproachButton.gameObject.SetActive(false);

        FPrinncess.gameObject.SetActive(true);
        Smonster.gameObject.SetActive(true);
        BackButton.gameObject.SetActive(true);
        FPrinncess.transform.position = new Vector3(-4, 1, 85);
        Smonster.transform.position = new Vector3(-6, -1, 80);
    }
    public void PressAvoid()
    {
        FleeButton.gameObject.SetActive(false);
        SeekButton.gameObject.SetActive(false);
        AvoidButton.gameObject.SetActive(false);
        SKnight.gameObject.SetActive(false);
        FPrinncess.gameObject.SetActive(false);
        Smonster.gameObject.SetActive(false);
        TitleScreen.SetActive(false);
        Titletext.SetActive(false);
        ApproachButton.gameObject.SetActive(false);

        AKnight.gameObject.SetActive(true);
        Princess.gameObject.SetActive(true);
        monster.gameObject.SetActive(true);
        BackButton.gameObject.SetActive(true);

        AKnight.transform.position = new Vector3(6, -2, 80);
        Princess.transform.position = new Vector3(-4, 4,80);
        monster.transform.position = new Vector3(-1, 1, 80);

    }
    public void PressApproach()
    {
        FleeButton.gameObject.SetActive(false);
        SeekButton.gameObject.SetActive(false);
        AvoidButton.gameObject.SetActive(false);
        SKnight.gameObject.SetActive(false);
        FPrinncess.gameObject.SetActive(false);
        Smonster.gameObject.SetActive(false);
        TitleScreen.SetActive(false);
        Titletext.SetActive(false);
        ApproachButton.gameObject.SetActive(false);

        AKnight.gameObject.SetActive(true);
        Princess.gameObject.SetActive(true);
        monster.gameObject.SetActive(true);
        BackButton.gameObject.SetActive(true);

        AKnight.transform.position = new Vector3(6, -2, 80);
        Princess.transform.position = new Vector3(-4, 4, 80);
        monster.transform.position = new Vector3(-9, 7, 80);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
