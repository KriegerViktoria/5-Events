using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string levelToLoad;

    public Vector3 mousePos;
    public Camera mainCam;
    public Vector3 mousePosWorld;
    public Vector2 mousePos2d;
    RaycastHit2D hit;
    // Start is called before the first frame update
    void Start()
    {

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
                SceneManager.LoadScene(levelToLoad);

            }
        }
    }
}