public class Spawner
{
    public Transform m_prefab;
 
    public void Start()
    {
        Transform t = Instantiate(m_prefab) as Transform; // instantiate prefab and get its transform
        t.parent = transform; // group the instance under the spawner
        t.localPosition = Vector3.zero; // make it at the exact position of the spawner
        t.localRotation = Quaternion.identity; // same for rotation
        t.gameObject.name = "My Awesome Instance!";
    }
}
