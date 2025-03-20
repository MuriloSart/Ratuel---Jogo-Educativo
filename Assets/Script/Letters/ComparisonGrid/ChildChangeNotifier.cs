using Letter.Generator;
using UnityEngine;
using UnityEngine.Events;

public class ChildChangeNotifier : MonoBehaviour
{
    public ComparisonGrid comparison;

    [SerializeField] private UnityEvent onChildAdded;

    private int lastChildCount;

    void Start()
    {
        lastChildCount = transform.childCount;
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
