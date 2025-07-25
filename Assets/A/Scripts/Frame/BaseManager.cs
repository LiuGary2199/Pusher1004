/// <summary>
/// 不继承 MonoBehaviour 的单例模式基类
/// </summary>
public class BaseManager<T> where T : new()
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new T();
            }
            return _instance;
        }
    }
}
