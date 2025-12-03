public enum NivelAcceso
{
    ADMINISTRADOR,
    CAJERO,
    COBRANZA,
    VENDEDOR,
    SISTEMAS,
    SUPERVISOR
}

public enum action
{
    insert,
    query,
    update,
    free
}

public enum messageResponse
{
    conectionFail,
    actionFail,
    actionSuccess,
    fieldsRequired,
    allActionFail,
}