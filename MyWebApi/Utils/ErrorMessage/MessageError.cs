namespace MyWebApi.Utils.ErrorMessage;

public static class MessageError
{
    public const string RequiredField = "Ce champ est obligatoire.";
    public const string MaxLengthExceeded = "La longueur maximale autoris�e est de {0} caract�res.";
    public const string InvalidDate = "La valeur doit �tre une date valide.";
    public const string EndDateBeforeStartDate = "La date de fin doit �tre post�rieure � la date de d�but.";
    public const string PropertyNotFound = "Propri�t� {0} introuvable.";
}
