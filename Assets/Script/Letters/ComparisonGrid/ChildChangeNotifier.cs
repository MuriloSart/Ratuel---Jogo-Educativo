using UnityEngine;
using UnityEngine.Events;

public class ChildChangeNotifier : MonoBehaviour
{
    [SerializeField] private UnityEvent onChildAdded;

    private ComparisonGrid comparison;

    private int lastChildCount;

    void Start()
    {
        lastChildCount = transform.childCount;
        comparison = GetComponent<ComparisonGrid>();
    }

    void Update()
    {
        if (transform.childCount > lastChildCount)
        {
            comparison.LetterAdded();
            onChildAdded?.Invoke();
        }
        else if (transform.childCount < lastChildCount)
        {
            comparison.LetterRemoved();
        }
        
        lastChildCount = transform.childCount;
    }
}
