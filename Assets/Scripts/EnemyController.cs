using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Transform exclaimationMark;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Point");
            StartCoroutine(ExclaimAnimation());
        }
    }

    private IEnumerator ExclaimAnimation()
    {
        Vector3 originalScale = exclaimationMark.localScale;
        exclaimationMark.gameObject.SetActive(true);

        Vector3 startScale = new Vector3(originalScale.x * 4.0f, 0.0f, 1.0f);
        Vector3 endScale = originalScale;
        float animTime = 0.1f;

        for (float t = 0.0f; t < animTime; t += Time.deltaTime)
        {
            exclaimationMark.localScale = Vector3.Lerp(startScale, endScale, t / animTime);
            yield return null;
        }

        yield return new WaitForSeconds(0.8f);

        for (float t = 0.0f; t < animTime; t += Time.deltaTime)
        {
            exclaimationMark.localScale = Vector3.Lerp(endScale, startScale, t / animTime);
            yield return null;
        }

        exclaimationMark.localScale = originalScale;
        exclaimationMark.gameObject.SetActive(false);
    }
}
