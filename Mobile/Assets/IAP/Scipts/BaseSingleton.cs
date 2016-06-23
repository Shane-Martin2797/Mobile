using UnityEngine;
using System.Collections;

public class BaseSingleton<T> : MonoBehaviour
	where T : MonoBehaviour
{

	private static T _instance;


	public static T Instance 
	{
		get 
		{
			return _instance;
		}
	}

	void Awake()
	{
		if (_instance == null) {
			_instance = this as T;
		} else {
			Destroy (gameObject);
		}
	}
		
	void OnDestroy()
	{
		if (_instance == this) {
			_instance = null;
		}
	}

	public virtual void OnSingletonAwake() {}
	public virtual void OnSingletonDestroy() {}
}
