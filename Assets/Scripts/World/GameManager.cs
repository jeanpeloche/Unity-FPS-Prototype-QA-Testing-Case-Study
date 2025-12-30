using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    public Text ammoText;

    public static GameManager Instance { get; private set; }

    public int gunAmmo = 25;

    public Text healthText;

    public int health = 100;

    private void Awake()
    {
        Instance = this;
    }


    private void Update()
    {
        ammoText.text = gunAmmo.ToString();

        healthText.text = health.ToString();
    }


}
