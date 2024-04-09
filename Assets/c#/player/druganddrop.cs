using UnityEngine;
 
[RequireComponent(typeof(Rigidbody2D))]
public class druganddrop : MonoBehaviour
{
    private bool _isDraged = false;

    private Plane _planeXY;
 
    private Rigidbody2D _rb2D;
    private HingeJoint2D _hindleJoint2D;
 
    void Start()
    {
        _rb2D = GetComponent<Rigidbody2D>();
        _rb2D.isKinematic = true;
 
        _isDraged = false;
    }
 
    void Update()
    {
        // начинаем перетаскивание, если нажали на объект с тегом "seed" в сцене и нет другого перетаскиваемого объекта
        if (Input.GetMouseButtonDown(0) && _isDraged == false)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2D = Physics2D.GetRayIntersection(ray);

            if (hit2D.collider != null && hit2D.collider.CompareTag("seed"))
            {
                _planeXY = new Plane(Vector3.forward, hit2D.transform.position);

                _rb2D.position = hit2D.point;

                _hindleJoint2D = hit2D.transform.gameObject.AddComponent<HingeJoint2D>();
                _hindleJoint2D.connectedBody = this._rb2D;
 
                _isDraged = true;
            }
        }
 
        // прекращаем перетаскивание при отпускании мыши
        if (Input.GetMouseButtonUp(0) && _isDraged)
        {
            Destroy(_hindleJoint2D);
            _isDraged = false;
        }
 
        // реализанция перетаскивания
        if (_isDraged)
        {
            if (_hindleJoint2D == null || _hindleJoint2D.gameObject == null)
            {
                _hindleJoint2D = null;
                _isDraged = false;
                return;
            }
 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (_planeXY.Raycast(ray, out float enterPoint))
            {
                _rb2D.position = ray.GetPoint(enterPoint);
            }
        }
    }
 
    private void OnDestroy()
    {
        if (_hindleJoint2D != null && _hindleJoint2D.gameObject != null)
        {
            Destroy(_hindleJoint2D);
        }
    }
}