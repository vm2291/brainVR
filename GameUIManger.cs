using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameUImanger : MonoBehaviour
{
    public GameObject startButton;
    public GameObject labDoor;
    public GameObject Dilog;
    public GameObject mainmenu;

    public void StartGame()
    {
        startButton.SetActive(false);
        labDoor.SetActive(true);
        Dilog.SetActive(true);
        mainmenu.SetActive(true);
    }

    void Start()
    {

    }
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space)){

            StartGame();
        }

    }

}