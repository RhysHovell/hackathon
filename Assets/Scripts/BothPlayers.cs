using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BothPlayers : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        players.Add(player1);
        players.Add(player2);

    }

    public GameObject playerPrefab;

    public GameObject player1;
    public GameObject player2;
    public HealthController player1HC = new HealthController();
    public HealthController player2HC = new HealthController();

    Clinton clinton = new Clinton();

    public Trump trump = new Trump();

    public GameObject email;
    public GameObject wall;

    public AudioClip emailSound;

    public AudioClip kickSound;
    public AudioClip punchSound;

    public AudioClip clintonJump;
    public AudioClip trumpJump;

    public List<GameObject> players = new List<GameObject>();
    float speed = 3;

    void Update()
    {
        foreach (GameObject player in GameObject.FindObjectsOfType(typeof(GameObject)))
        {
            if (player.name.Contains("Player") && !players.Contains(player))
                players.Add(player);
        }

        if (Input.GetKey(KeyCode.A))
        {
            players[0].transform.localRotation = Quaternion.Euler(0, 0, 0);
            Animator animationObj = players[0].GetComponent<Animator>();
            animationObj.SetBool("isWalking", true);
            players[0].transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            Animator animationObj = players[0].GetComponent<Animator>();
            animationObj.SetBool("isWalking", false);
            animationObj.Play("trump_still");
        }

        if (Input.GetKey(KeyCode.D))
        {
            players[0].transform.localRotation = Quaternion.Euler(0, 180, 0);
            Animator animationObj = players[0].GetComponent<Animator>();
            animationObj.SetBool("isWalking", true);
            players[0].transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Animator animationObj = players[0].GetComponent<Animator>();
            animationObj.SetBool("isWalking", false);
            animationObj.Play("trump_still");
        }

        if (Input.GetKey(KeyCode.E))
        {
            trump.WallAttack();
            //Rigidbody2D r = wall.GetComponent<Rigidbody2D>();
            //r.gravityScale = 10;
            Animator animationObj = players[0].GetComponent<Animator>();
            animationObj.SetBool("isAttacking", true);
            animationObj.Play("trump_attack");

                DestroyObject(wall, 0.7f);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            Animator animationObj = players[0].GetComponent<Animator>();
            animationObj.SetBool("isAttacking", false);

            Animator a = players[0].GetComponent<Animator>();
            a.Play("trump_still");
        }

        if (Input.GetKey(KeyCode.W))
        {
            players[0].transform.Translate(Vector3.up * speed * Time.deltaTime);
            AudioManager.audioInstance.Play(trumpJump);
        }
            
        if (Input.GetKey(KeyCode.S))
            players[0].transform.Translate(Vector3.down * speed * Time.deltaTime);

       




        if (Input.GetKey(KeyCode.LeftArrow))
        {
            players[1].transform.localRotation = Quaternion.Euler(0, 180, 0);
            Animator animationObj = players[1].GetComponent<Animator>();
            animationObj.SetBool("isWalking", true);
            players[1].transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            Animator animationObj = players[1].GetComponent<Animator>();
            animationObj.SetBool("isWalking", false);
            animationObj.Play("trump_still");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            players[1].transform.localRotation = Quaternion.Euler(0, 0, 0);
            Animator animationObj = players[1].GetComponent<Animator>();
            animationObj.SetBool("isWalking", true);
            players[1].transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Animator animationObj = players[1].GetComponent<Animator>();
            animationObj.SetBool("isWalking", false);
            animationObj.Play("trump_still");
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            players[1].transform.Translate(Vector3.up * speed * Time.deltaTime);
            AudioManager.audioInstance.Play(clintonJump);
        }
           
        if (Input.GetKey(KeyCode.DownArrow))
            players[1].transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space))
        {
            //clinton.EmailAttack();
            Rigidbody2D r = email.GetComponent<Rigidbody2D>();
            r.gravityScale = 10;
            Animator animationObj = players[1].GetComponent<Animator>();
            animationObj.SetBool("isAttacking", true);
            animationObj.Play("clinton_attack");

            Debug.Log("email attack");
             AudioManager.audioInstance.Play(emailSound);

            DestroyObject(email, 0.7f);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Animator animationObj = players[1].GetComponent<Animator>();
            animationObj.SetBool("isAttacking", false);

            Animator a = players[1].GetComponent<Animator>();
            a.Play("clinton_still");
        }

        if (inTrigger)
        {
            if (Input.GetKey(KeyCode.F))
            {
                Animator animationObj = players[0].GetComponent<Animator>();
                animationObj.SetBool("isAttacking", true);
                animationObj.Play("trump_kick");

                AudioManager.audioInstance.Play(kickSound);

                Vector3 punch = new Vector3(players[1].transform.position.x - 4, 0, 0);
                players[1].transform.Translate(punch);
            }
            if (Input.GetKeyUp(KeyCode.F))
            {
                Animator animationObj = players[0].GetComponent<Animator>();
                animationObj.SetBool("isAttacking", false);

                Animator a = players[0].GetComponent<Animator>();
                a.Play("trump_still");
            }

            if (Input.GetKey(KeyCode.G))
            {
                Animator animationObj = players[0].GetComponent<Animator>();
                animationObj.SetBool("isAttacking", true);
                animationObj.Play("trump_attack");

                AudioManager.audioInstance.Play(punchSound);

                Debug.Log("players[1]: " + players[1].transform.position.x);
                Vector3 punch = new Vector3(players[1].transform.position.x - 2, 0, 0);
                players[1].transform.Translate(punch);
            }
            if (Input.GetKeyUp(KeyCode.G))
            {
                Animator animationObj = players[0].GetComponent<Animator>();
                animationObj.SetBool("isAttacking", false);

                Animator a = players[0].GetComponent<Animator>();
                a.Play("trump_still");
            }


            if (Input.GetKey(KeyCode.N))
            {
                Animator animationObj = players[1].GetComponent<Animator>();
                animationObj.SetBool("isAttacking", true);
                animationObj.Play("attack_kick");

                AudioManager.audioInstance.Play(kickSound);

                Vector3 punch = new Vector3(players[0].transform.position.x + 4, 0, 0);
                players[0].transform.Translate(punch);
            }
            if (Input.GetKeyUp(KeyCode.N))
            {
                Animator animationObj = players[1].GetComponent<Animator>();
                animationObj.SetBool("isAttacking", false);

                Animator a = players[1].GetComponent<Animator>();
                a.Play("clinton_still");
            }

            if (Input.GetKey(KeyCode.M))
            {
                Animator animationObj = players[1].GetComponent<Animator>();
                animationObj.SetBool("isAttacking", true);
                animationObj.Play("attack");

                AudioManager.audioInstance.Play(punchSound);

                Debug.Log("c punch: " + GameObject.Find("Trump").transform.position.x);
                Vector3 punch = new Vector3(GameObject.Find("Trump").transform.position.x + 2, 0, 0);
                players[0].transform.Translate(punch);
            }
            if (Input.GetKeyUp(KeyCode.M))
            {
                Animator animationObj = players[1].GetComponent<Animator>();
                animationObj.SetBool("isAttacking", false);

                Animator a = players[1].GetComponent<Animator>();
                a.Play("clinton_still");
            }

        }
    }

    bool inTrigger = false;

    void OnTriggerExit2D(Collider2D obj)
    {
        inTrigger = false;
    }

        void OnTriggerEnter2D(Collider2D obj)
        {
            inTrigger = true;
            if (obj.name == "Player2")
            {
                player2HC.TakeDamage(10);
            }

        
    }            

}
