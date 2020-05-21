using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//20.05 scenewechsel
using UnityEngine.SceneManagement;

public class PointandClickScript : MonoBehaviour
{
    public Vector3 mousePos;
    public Camera mainCam;
    public Vector3 mousePosWorld;
    public Vector2 mousePos2d;
    RaycastHit2D hit;

   // public float[] playerpos; 

    public GameObject player;

    public Vector2 targetPos;
    public float speed;
    public bool isMoving;
    

    public Animator MCAnimator;

    //10.05 Inventory
    private Inventory inventory;
    public GameObject itemButton;
    public GameObject effect;



    // Start is called before the first frame update
    void Start()
    {


        // 10.05 Inventory
        //inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        //playerpos = new float[2];
        //playerpos[1] = player.transform.position.x;
        //playerpos[2] = player.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

       if(Input.GetMouseButtonDown(0))
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

            //Überprüfe ob der Ray einen Collider trifft
            if (hit.collider != null)
            {
                //Name des Objektes ausgeben
                print("Hit! " + hit.collider.gameObject.name);

                if (hit.collider.gameObject.tag == "Ground")
                {
                    //Koordinaten werden in einer variable gespeichert, die man dann zum bewegen braucht
                    targetPos = hit.point;

                    isMoving = true;
                  

                    //Überprüfen ob Sprite-Flip notwendig ist
                    CheckSpriteFlip();
                }
          
            }
          

        }

    }

    //Daten Speichern Versuch 21.05
    private void OnDestroy()
    {
      //  PlayerPrefs.SetFloat("playerPos", playerpos);
    }

    void CheckSpriteFlip()
    {
        //Spieler spiegeln damit Blickrichtung stimmt
    

        if (player.transform.position.x > targetPos.x)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }
  
    //Fixed update, damit sich der Character überall gleich bewegt und nicht frame bezogen
    private void FixedUpdate()
    {
        //Spieler an Mausklick laufen lassen
        if (isMoving)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, targetPos, speed);
            MCAnimator.SetBool("Walk", true);

            if(player.transform.position.x == targetPos.x || player.transform.position.y == targetPos.y)
            {
                isMoving = false;
                MCAnimator.SetBool("Walk", false);
            }
        }
      }



     


                              
    }
