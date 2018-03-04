using UnityEngine;
using System.Collections;

public class Clinton : MonoBehaviour
{
    public HealthController hc = new HealthController();
    public AudioClip emailSound;
    public AudioClip punchSound;
    public AudioClip kickSound;

    public GameObject email;

    public void EmailAttack()
    {
        AudioManager.audioInstance.Play(emailSound);
        Rigidbody2D r = email.GetComponent<Rigidbody2D>();
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
}
