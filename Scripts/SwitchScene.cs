using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
	public void Switch()
	{
		SceneManager.LoadScene(m_SceneToLoad);
	}

	[SerializeField]
	private string m_SceneToLoad;
}
