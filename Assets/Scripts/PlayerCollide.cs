using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerCollide : MonoBehaviour
{
    public GameObject Cat1;
    public GameObject Cat2;
    public GameObject Cat3;
    public GameObject CatS1;
    public GameObject CatS2;
    public GameObject CatS3;

    public Text instructions;




    // Start is called before the first frame update
    void Start()
    {
        instructions.text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Catbox")
        {
            Cat3.SetActive(true);
            CatS3.SetActive(false);
            instructions.text = "Not my kitty!!";
        }
        if (other.tag == "CatStatue")
        {
            Cat2.SetActive(true);
            CatS2.SetActive(false);
        }
        if (other.tag == "CatToy")
        {
            Cat1.SetActive(true);
            CatS1.SetActive(false);
        }




    }









}

