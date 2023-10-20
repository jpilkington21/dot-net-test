namespace EngineeringServices.Repository.MaintenanceTasks;

using EngineeringServices.DomainObjects;

public interface IMaintenanceTaskRepository
{
  Dictionary<int, MaintenanceTask> allMaintenanceTasks();
    MaintenanceTask maintenanceTaskById(int id);
}
