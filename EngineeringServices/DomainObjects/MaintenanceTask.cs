namespace EngineeringServices.DomainObjects;

public record MaintenanceTask(
    int ID,
    string Description,
    DateTime DateRequired,
    MaintenanceCode Code);