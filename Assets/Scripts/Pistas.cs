using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Mono.Cecil;


public class Pistas : MonoBehaviour
{
    [SerializeField] private  Player player;
    [SerializeField] GameObject Dicas;
    [SerializeField] private TextMeshProUGUI carta;
    [SerializeField] private bool estaLendo;
    [SerializeField] private bool naoEstaLendo;

    Animator Player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        Dicas = GameObject.FindWithTag("Dicas").gameObject;
        Dicas.SetActive(false);
        carta = GameObject.FindWithTag("Papel1").GetComponent<TextMeshProUGUI>();
        estaLendo = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.CompareTag("Player"))
        {
            estaLendo = true;
            LendoPista();
        }
        
    }

    public void LendoPista()
    {
        if(gameObject.CompareTag("OI"))
        {
            gameObject.CompareTag("Player");
            Dicas.SetActive(true);
            carta.text = "asdasdasdasdasdasdasd";
            estaLendo = true;
           
        }
        new WaitForSeconds(2);
        Dicas.SetActive(false);
        return;
    }
 
    }
            


