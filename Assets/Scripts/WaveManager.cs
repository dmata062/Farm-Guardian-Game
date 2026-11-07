using UnityEngine;
using TMPro;
using System.Collections;

public class WaveManager : MonoBehaviour
{
    public GameObject enemy11w1;
    public GameObject enemy12w1;
    public GameObject enemy13w1;

    public GameObject enemy2w1;

    public GameObject enemy11w2;
    public GameObject enemy12w2;
    public GameObject enemy13w2;
    public GameObject enemy14w2;
    public GameObject enemy15w2;

    public GameObject enemy21w2;
    public GameObject enemy22w2;


    public TextMeshProUGUI waveText;
    

    
    public float plantingTime = 180f;

    void Start()
    {
        StartCoroutine(GameLoop());
    }

    IEnumerator GameLoop()
    {
        
        waveText.text = "Planting Phase";

        yield return new WaitForSeconds(plantingTime);

        
        waveText.text = "Wave 1";

        SpawnWave1();

        
        while (GameObject.FindGameObjectsWithTag("Enemy1").Length > 0 || GameObject.FindGameObjectsWithTag("Enemy2").Length > 0)
        {
            yield return null;
        }

        
        waveText.text = "Planting Phase";

        yield return new WaitForSeconds(plantingTime);

        
        waveText.text = "Final Wave";

        SpawnWave2();

       
        while (GameObject.FindGameObjectsWithTag("Enemy2").Length > 0 || GameObject.FindGameObjectsWithTag("Enemy1").Length > 0)
        {
            yield return null;
        }

        
        waveText.text = "YOU WIN!";
    }

    void SpawnWave1()
    {
        enemy11w1.SetActive(true);
        enemy12w1.SetActive(true);
        enemy13w1.SetActive(true);
        enemy2w1.SetActive(true);
        
        
    }

    void SpawnWave2()
    {
        enemy11w2.SetActive(true);
        enemy12w2.SetActive(true);
        enemy13w2.SetActive(true);
        enemy14w2.SetActive(true);
        enemy15w2.SetActive(true);
        enemy21w2.SetActive(true);
        enemy22w2.SetActive(true);
    }
}