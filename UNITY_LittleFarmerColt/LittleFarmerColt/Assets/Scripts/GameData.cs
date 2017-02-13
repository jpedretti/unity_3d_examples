using UnityEngine;

public class GameData : MonoBehaviour
{
    #region Private Fields

    private static int _corn = 0;
    private static int _water = 0;

    #endregion Private Fields

    #region Public Properties

    public static int Corn
    {
        get { return _corn; }

        set { _corn = value; }
    }

    public static int Water
    {
        get { return _water; }

        set { _water = value; }
    }

    #endregion Public Properties

    #region Private Methods

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    #endregion Private Methods
}