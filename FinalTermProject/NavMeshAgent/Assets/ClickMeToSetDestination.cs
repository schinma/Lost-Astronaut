using UnityEngine;
using System.Collections;

public class ClickMeToSetDestination : MonoBehaviour
{

    private UnityEngine.AI.NavMeshAgent playerNavMeshAgent;

    private MeshRenderer meshRenderer;

    private bool mouseOver = false;

    private Color unselectedColor;

    void Start()
    {

        meshRenderer = GetComponent<MeshRenderer>();

        unselectedColor = meshRenderer.sharedMaterial.color;

        GameObject playerGO =
        GameObject.FindGameObjectWithTag("Player");

        playerNavMeshAgent =
        playerGO.GetComponent<UnityEngine.AI.NavMeshAgent>();

    }

    void Update()
    {

        if (Input.GetButtonDown("Fire1") && mouseOver)

            playerNavMeshAgent.SetDestination(transform.position);

    }

    void OnMouseOver()
    {

        mouseOver = true;

        meshRenderer.sharedMaterial.color = Color.yellow;

    }

    void OnMouseExit()
    {

        mouseOver = false;

        meshRenderer.sharedMaterial.color = unselectedColor;

    }

}
