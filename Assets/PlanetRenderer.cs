using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRenderer : MonoBehaviour
{
    public GameObject[] planetPrefabs;

    private GameObject lastPlanet;
    private int lastGeneratedType;

    // Start is called before the first frame update
    float getLastPlanetDistance()
    {
        return Vector3.Distance(lastPlanet.transform.position, transform.position);
    }
    
    void generateNewPlanet()
    {
        // bi önceki gezegeni öldür, birikmesinler
        Destroy(lastPlanet);

        // yeni gezegenin array indexini belirle
        int newRandomInt = Random.Range(0, 7);
        if (lastGeneratedType == newRandomInt)
        {
            newRandomInt = (newRandomInt + 1) % 7;
        }

        GameObject randomPlanet = planetPrefabs[newRandomInt];

        // yeni gezegenin x koordinatı ve büyüklüğünü belirle
        float randX = Random.Range(-3f, 3f);
        float scale = Random.Range(2f, 3f);
        GameObject generatedPlanet = Instantiate(randomPlanet, new Vector3(randX, transform.position.y + 12f, 0), Quaternion.identity);
        
        generatedPlanet.transform.localScale = new Vector3(scale, scale, 0);
        lastPlanet = generatedPlanet;
        lastGeneratedType = newRandomInt;
    }

    bool shouldGenerateNewPlanet()
    {
        // hiç gezegen oluşturmadık
        if (lastPlanet == null) 
        {
            return true;
        }

        float lastPlanetDistance = getLastPlanetDistance();
        float generationChance = Random.Range(0.0f, 1.0f);

        // son oluşturduğumuz gezegenden uzaklaştıysak 1/2 ihtimalle yeni gezegen oluştur
        return (lastPlanetDistance > 20 && generationChance > 0.5f && lastPlanet.transform.position.y < transform.position.y);
    }

    void Start()
    {
        lastGeneratedType = -1;
        generateNewPlanet();
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldGenerateNewPlanet())
        {
            generateNewPlanet();
        }
    }
}
