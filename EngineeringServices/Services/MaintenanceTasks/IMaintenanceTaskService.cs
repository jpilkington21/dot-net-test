namespace EngineeringServices.Services.MaintenanceTasks;

using EngineeringServices.DomainObjects;

public interface IMaintenanceTaskService
{
  Dictionary<int, MaintenanceTask> allMaintenanceTasks();
    MaintenanceTask maintenanceTaskById(int id);
}
