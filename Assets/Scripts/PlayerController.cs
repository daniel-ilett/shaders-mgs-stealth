using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;

    [SerializeField] private List<Renderer> renderers;
    [SerializeField] private Material stealthMaterial;
    [SerializeField] private GameObject stealthItemIcon;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        bool isRunning = (Input.GetKey(KeyCode.Space));
        animator.SetBool("IsRunning", isRunning);

        if(Input.GetKeyDown(KeyCode.S))
        {
            for(int i = 0; i < renderers.Count; ++i)
            {
                var materials = renderers[i].materials;

                for(int j = 0; j < materials.Length; ++j)
                {
                    materials[j] = stealthMaterial;
                }

                renderers[i].materials = materials;
            }

            stealthItemIcon.SetActive(true);
        }
    }
}
