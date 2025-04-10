namespace MyWebApi.Utils.ErrorMessage;

public static class MessageError
{
    public const string RequiredField = "Ce champ est obligatoire.";
    public const string MaxLengthExceeded = "La longueur maximale autorisée est de {0} caractères.";
    public const string InvalidDate = "La valeur doit être une date valide.";
    public const string EndDateBeforeStartDate = "La date de fin doit être postérieure à la date de début.";
    public const string PropertyNotFound = "Propriété {0} introuvable.";
}
