using UnityEngine;
using System.Collections;

public class CropGrowth : MonoBehaviour
{
    
    public GameObject stage1;
    public GameObject stage2;
    public GameObject stage3;
    public GameObject stage4;

    public float stage1Time = 5f;
    public float stage2Time = 5f;
    public float stage3Time = 5f;

    

    private bool readyToHarvest = false;

    void Start()
    {
        StartCoroutine(GrowCrop());
    }

    IEnumerator GrowCrop()
    {
        
        yield return new WaitForSeconds(stage1Time);

        stage1.SetActive(false);
        stage2.SetActive(true);

        
        yield return new WaitForSeconds(stage2Time);

        stage2.SetActive(false);
        stage3.SetActive(true);

        
        yield return new WaitForSeconds(stage3Time);

        stage3.SetActive(false);
        stage4.SetActive(true);

        readyToHarvest = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (readyToHarvest && other.CompareTag("Player"))
        {

            PlayerInventory inventory = other.GetComponent<PlayerInventory>();

            inventory.corn += 2;

            

            Destroy(gameObject);
        }
    }
}