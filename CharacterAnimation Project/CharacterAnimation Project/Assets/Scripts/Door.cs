using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public GameObject SpawnPoint;
    public Camera newCamera;
    private GameObject Player;

    public Vector3 mousePos;
    public Camera mainCam;
    public Vector3 mousePosWorld;
    public Vector2 mousePos2d;
    RaycastHit2D hit;
    public GameObject Blende;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
       // mainCam.enabled = true;
       // newCamera.enabled = false;
      
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            // MousePosition muss umgewandelt werden, da sonst die Kooridinaten der Screenspace genommen wird
            // Koordinaten würden sich wiederholen! 
      
            mousePos = Input.mousePosition;
      
            print("Screen Space: " + mousePos);
            mousePosWorld = mainCam.ScreenToWorldPoint(mousePos);
            print("World Space: " + mousePosWorld);
      
            //Muss MousePosWorld in einen Vector2 umwandeln, da Physics2D/Raycast nur damit arbeiten kann
            mousePos2d = new Vector2(mousePosWorld.x, mousePosWorld.y);
      
            // RayCast
            hit = Physics2D.Raycast(mousePos2d, Vector2.zero);
            //Scenenwechsel 20.05
      
            if (hit.collider.gameObject.tag == "Door")
            {
                //  SceneManager.LoadScene(levelToLoad);

                //27.05 Scenenübergang
                Blende.GetComponent<SpriteRenderer>().enabled = true;
                Player.transform.position = SpawnPoint.transform.position;
                mainCam.enabled = false;
               newCamera.enabled = true;

                
                
            }
            else
            {
                Blende.GetComponent<SpriteRenderer>().enabled = false;
            }
        }
    }
}