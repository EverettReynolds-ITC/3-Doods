using UnityEngine;

public class TrajectoryLine : MonoBehaviour
{
    [SerializeField] private int _segmentCount = 50;
    [SerializeField] private Transform _bulletSpawnPoint;

    [SerializeField] private float _curveLength = 3.5f;

    private Vector2[] _segments;
    private LineRenderer _lineRenderer;
    private float _projectileSpeed = 30f;
    private float _gravity = .0612f;
    private void Start()
    {
        _segments = new Vector2[_segmentCount];

        _lineRenderer = GetComponent<LineRenderer>();
        _lineRenderer.positionCount = _segmentCount;

        
    }
    private void Update()
    {
        Vector2 startPos = _bulletSpawnPoint.position;
        _segments[0] = startPos;
        _lineRenderer.SetPosition(0, startPos);

        Vector2 startVelocity = transform.right * _projectileSpeed;

        for (int i = 1; i < _segmentCount; i++)
        {
            float timeOffset = (i * Time.fixedDeltaTime * _curveLength);

            Vector2 gravityOffset = 50 * Physics2D.gravity * _gravity * Mathf.Pow(timeOffset, 2);
            _segments[i] = _segments[0] + startVelocity * timeOffset + gravityOffset;
            _lineRenderer.SetPosition(i, _segments[i]);
        }
    }
}
