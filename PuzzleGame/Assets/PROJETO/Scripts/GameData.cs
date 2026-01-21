using UnityEngine;

public class GameData
{
    [Header("Verificacao se esta no centro")]
    public static bool IsInCenter = true;

    public static Vector3 CenterPointTarget = new Vector3(0, 5, 0); //talvez usar pra mudar de fase

    [Header("Objetos de Interacao / Coletaveis")]
    public static bool door_level_1 = false;
}
