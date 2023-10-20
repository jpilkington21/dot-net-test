namespace EngineeringServices.Tests;

using EngineeringServices.DomainObjects;
using EngineeringServices.Services.MaintenanceTasks;
using EngineeringServices.Repository.MaintenanceTasks;


[TestFixture]
public class MaintenanceTaskServiceTests
{
    [Test]
    public void allMaintenanceTasks_runs_anyResponse()
    {
        // arrange
        var repo = new Mock<IMaintenanceTaskRepository>();
        repo.Setup(m => m.allMaintenanceTasks()).Returns(
            new Dictionary<int, MaintenanceTask>() {
                { 1, new MaintenanceTask(1, string.Empty, System.DateTime.MinValue, MaintenanceCode.B7) }
            }
        );
        var service = new MaintenanceTaskService(repo.Object);

        // act
        var result = service.allMaintenanceTasks();

        // assert
        Assert.NotNull(result);
    }

    [Test]
    public void maintenanceTaskById_getSpeificId_correctReturned()
    {
        // arrange
        var repo = new Mock<IMaintenanceTaskRepository>();
        repo.Setup(m => m.maintenanceTaskById(It.IsAny<int>())).Returns(
            new MaintenanceTask(1, string.Empty, System.DateTime.MinValue, MaintenanceCode.B7)
        );
        var service = new MaintenanceTaskService(repo.Object);

        // act
        var result = service.maintenanceTaskById(1);

        // assert
        Assert.AreEqual(1, result.ID);
    }
}
