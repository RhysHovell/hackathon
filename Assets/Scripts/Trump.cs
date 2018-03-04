using UnityEngine;
using System.Collections;

public class Trump : MonoBehaviour {
    public HealthController hc = new HealthController();
    public AudioClip wallSound;
    public AudioClip punchSound;
    public AudioClip kickSound;

    public GameObject wall;

    public void WallAttack()
    {
        AudioManager.audioInstance.Play(wallSound);
        Rigidbody2D r = wall.GetComponent<Rigidbody2D>();
        r.gravityScale = 10;
    }

    public void punch()
    {
         AudioManager.audioInstance.Play(punchSound);
        hc.TakeDamage(5);
    }

    public void kick()
    {
         AudioManager.audioInstance.Play(kickSound);
        hc.TakeDamage(5);
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
            //hc.TakeDamage(10);
            //DestroyObject(wall, 1);
    }    
}
