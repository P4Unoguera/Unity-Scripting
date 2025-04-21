using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HayMachine : MonoBehaviour
{
    public Vector3 translationSpeed;
    public GameObject hayBalePrefab;
    public Transform haySpawnpoint;
    public float shootInterval;
    public Transform modelParent;
    public GameObject blueModelPrefab;
    public GameObject yellowModelPrefab;
    public GameObject redModelPrefab;

    private float horizontalAxisBoundary = 22;
    private float shootTimer;

    // Start is called before the first frame update
    void Start()
    {
        LoadModel();
    }

    private void LoadModel()
    {
        Destroy(modelParent.GetChild(0).gameObject);

        switch (GameSettings.hayMachineColor)
        {
            case HayMachineColor.Blue:
                Instantiate(blueModelPrefab, modelParent);
                break;

            case HayMachineColor.Yellow:
                Instantiate(yellowModelPrefab, modelParent);
                break;

            case HayMachineColor.Red:
                Instantiate(redModelPrefab, modelParent);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Movement Controllers
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x <= horizontalAxisBoundary)
        {
            transform.Translate(translationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= -horizontalAxisBoundary)
        {
            transform.Translate(translationSpeed * Time.deltaTime * -1);
        }

        UpdateShooting();
    }

    private void UpdateShooting()
    {
        shootTimer -= Time.deltaTime;

        if (shootTimer <= 0 && Input.GetKey(KeyCode.Space))
        {
            shootTimer = shootInterval;
            ShootHay();
        }
    }

    private void ShootHay()
    {
        Instantiate(hayBalePrefab, haySpawnpoint.position, Quaternion.identity);
        SoundManager.Instance.PlayShootClip();
    }
}
