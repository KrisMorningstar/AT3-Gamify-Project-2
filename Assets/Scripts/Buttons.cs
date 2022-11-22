using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    [SerializeField] public GameObject[] rooms;
    private GameObject player;
    private GameObject fastTravel;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        fastTravel = GameObject.FindGameObjectWithTag("FastTravel");
    }

    private void Start()
    {
        fastTravel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if(!fastTravel.activeSelf) { fastTravel.SetActive(true); }
            else if (fastTravel.activeSelf) { fastTravel.SetActive(false); }
        }

        if (fastTravel.activeSelf) { player.GetComponentInChildren<MouseLook>().ToggleMouseLook(false, true); }
        else { player.GetComponentInChildren<MouseLook>().ToggleMouseLook(true, true); }
    }

    public void Kitchen()
    {
        player.transform.position = rooms[0].transform.position;
    }
    
    public void Bedroom()
    {
        player.transform.position = rooms[1].transform.position;
    }
    public void Lounge()
    {
        player.transform.position = rooms[2].transform.position;
    }
    public void Bathroom()
    {
        player.transform.position = rooms[3].transform.position;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
