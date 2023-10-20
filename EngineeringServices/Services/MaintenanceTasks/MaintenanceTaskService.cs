namespace EngineeringServices.Services.MaintenanceTasks;

using EngineeringServices.DomainObjects;
using EngineeringServices.Repository.MaintenanceTasks;

public class MaintenanceTaskService : IMaintenanceTaskService
{
  private readonly IMaintenanceTaskRepository repository;

  public MaintenanceTaskService(IMaintenanceTaskRepository repository) {
    this.repository = repository;
  }

  public Dictionary<int, MaintenanceTask> allMaintenanceTasks() =>
    repository.allMaintenanceTasks();

  public MaintenanceTask maintenanceTaskById(int id) =>
    repository.maintenanceTaskById(id);
}
