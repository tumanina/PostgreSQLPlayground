namespace PostgreSqlPlayground;

public enum EventType
{
    UserCreated,
    UserUpdated,
    UserRemoved,
    SessionStarted,
    SessionUpdated,
    SessionEnded,
    VehicleSelected,
    VehicleUpdated,
    VehicleRemoved,
    VehicleConnected,
    VehicleDisconnected,
    VehicleInvalidCredentials,
    ChargerConnected,
    ChargerDisconnected,
    ChargerInvalidCredentials,
    SessionImpossible,
    UtilityContractCreated,
    UtilityContractUpdated,
    UtilityContractRemoved,
    UtilityContractInvalidated,
}
