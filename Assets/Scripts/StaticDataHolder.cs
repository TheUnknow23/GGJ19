using UnityEngine;

public static class StaticDataHolder
{
    public static Vector3 playerPosition;
    public static bool secretRoom;

    public static Vector3 PlayerPosition
    {
        get { return playerPosition; }
        set { playerPosition = value; }
    }

    public static bool SecretRoom
    {
        get { return secretRoom; }
        set { secretRoom = value; }
    }
}
