using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public class DiaryTab : MonoBehaviour
{
    
    [SerializeField] protected CanvasGroup content;
    
    public Vector3 selectedScale = new Vector3(1.1f, 1.1f, 1.1f);
    public float scaleDuration = 0.1f;

    private Vector3 originalScale;
    private Coroutine scaleRoutine;


    
    private void Awake()
    {
        originalScale = transform.localScale;
        content.alpha = 0;
        content.interactable = false;
        content.blocksRaycasts = false;   
    }

    public void Select()
{
    content.alpha = 1;
    content.interactable = true;
    content.blocksRaycasts = true;

    ScaleTo(selectedScale);
}

public void Deselect()
{

    content.alpha = 0;
    content.interactable = false;
    content.blocksRaycasts = false;

    ScaleTo(originalScale);
}


    private void ScaleTo(Vector3 target)
    {
        if (scaleRoutine != null)
            StopCoroutine(scaleRoutine);

        scaleRoutine = StartCoroutine(ScaleOverTime(target));
    }

    IEnumerator ScaleOverTime ( Vector3 scale)
    {
        Vector3 startScale = transform.localScale;
        float timer = 0.0f;

        while (timer < scaleDuration)
        {
            timer += Time.deltaTime;
            transform.localScale = Vector3.Lerp(startScale,scale,timer/scaleDuration);
            yield return null;
        }
        transform.localScale = scale;
    }



    
}
