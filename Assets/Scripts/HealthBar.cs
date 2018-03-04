using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float healthBarAmount = 1;
    [SerializeField]
    private Image content;

    void Start()
    {

    }

    void Update()
    {
    }

    public void FillBar(float fillAmount)
    {
        healthBarAmount = fillAmount;
        content.fillAmount = healthBarAmount;
    }

}