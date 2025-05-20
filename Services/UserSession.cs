public sealed class UserSession
{
    private static UserSession? _instance;
    private int _currentUserId;

    private UserSession() { }
    public static UserSession GetInstance()
    {
        if (_instance is null)
        {
            _instance = new UserSession();
        }
        return _instance;
    }

    public void SetUser(int userId)
    {
        _currentUserId = userId;
    }
    public int GetCurrentUserId()
    {
        return _currentUserId;
    }

    /**
     * Questa la chiameremo nel logout ma non penso lo implementeremo nella console
     * App dato che è monoutente al momento
     */
    public void ClearUser()
    {
        // _currentUserId = null;
        throw new NotImplementedException();
    }
}
