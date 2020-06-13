using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public GameObject SpawnPoint;
  
    private GameObject Player;

    public Vector3 mousePos;
    public Camera mainCam;
    public Vector3 mousePosWorld;
    public Vector2 mousePos2d;
    RaycastHit2D hit;
    public GameObject Blende;

    public GameObject cmOld;
    public GameObject cmNew;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
       // mainCam.enabled = true;
       // newCamera.enabled = false;
      
    }

    // Update is called once per frame
    private void OnMouseDown()
            {
                //  SceneManager.LoadScene(levelToLoad);

                //27.05 Scenenübergang
                Blende.GetComponent<SpriteRenderer>().enabled = true;

                print(SpawnPoint.name);
                Player.transform.position = SpawnPoint.transform.position;
                cmOld.SetActive(false);
                cmNew.SetActive(true);
                
                
            }
      
}