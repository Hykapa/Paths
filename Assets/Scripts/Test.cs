using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    private Paths.Path _path;

    //[SerializeField]
    //private int _segment;

    //[SerializeField]
    //[Range(-1f, 10f)]
    //private float _distance;

    //[SerializeField]
    //private bool _useNormalizedDistance = true;

    //[SerializeField]
    //private bool _useGlobal = true;

    //[SerializeField]
    //private Transform[] _points;

    private void Awake() => _path = GetComponent<Paths.Path>();

    //private void OnDrawGizmosSelected()
    //{
    //    var position = _path.GetPoint(_distance, _useNormalizedDistance, _useGlobal);
    //    Gizmos.DrawSphere(position, 0.1f);
    //}

    //private void Update()
    //{
    //    var vectorA = _points[0].position - _points[1].position;
    //    var vectorB = _points[2].position - _points[1].position;

    //    print(Vector3.Dot(vectorA, vectorB));
    //}

    private IEnumerator Start()
    {
        while (true)
        {
            _path.Optimize();
            yield return new WaitForSeconds(0.05f);
        }
    }
}
