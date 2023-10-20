/*
*    THIS IS A TEST DATA CLASS - YOU DO NOT NEED TO CHANGE ANYTHING
*/
namespace EngineeringServices.Repository.MaintenanceTasks;

using EngineeringServices.DomainObjects;

public class MaintenanceTaskRepository : IMaintenanceTaskRepository
{
  
  public Dictionary<int, MaintenanceTask> allMaintenanceTasks() =>
    new() {
      { 1, new MaintenanceTask(1, "AFT CARGO NO 2 RUB STRIP PULLEY", DateTime.Now.AddDays(2), MaintenanceCode.D3) },
      { 2, new MaintenanceTask(2, "LAV-GALLEY FAN R STATUS MESSAGE", DateTime.Now.AddDays(3), MaintenanceCode.D3) },
      
      { 3, new MaintenanceTask(3, "SMOKE HOOD TIME EX AT D2R FWD", DateTime.Now.AddDays(6), MaintenanceCode.D7) },
      { 4, new MaintenanceTask(4, "RC TOILET CEILING LIGHT NOT WORKING", DateTime.Now.AddDays(-2), MaintenanceCode.D3) },
      { 5, new MaintenanceTask(5, "NO.3 BRAKE UNIT HYDRAULIC WEEP", DateTime.Now.AddDays(-7), MaintenanceCode.D3) },
      
      { 6, new MaintenanceTask(6, "TRAY TABLE HINGE U/S GRUB SCREW", DateTime.Now.AddDays(40), MaintenanceCode.D3) },
      { 7, new MaintenanceTask(7, "R+L PRE BOXES ARE CRACKED", DateTime.Now.AddDays(20), MaintenanceCode.D3) },
      
      { 8, new MaintenanceTask(8, "D4R - BUMP STRIP TO LEFT OF AT", DateTime.Now.AddDays(50), MaintenanceCode.D3) },
      { 9, new MaintenanceTask(9, "SEAT 23A CUSHION SEAT AND BACKREST", DateTime.Now.AddDays(52), MaintenanceCode.D3) },
      { 10, new MaintenanceTask(10, "REPORTED BY LOADING TEAM ON AR", DateTime.Now.AddDays(-1), MaintenanceCode.D3) },
      { 11, new MaintenanceTask(11, "SEAT 11J MAKING GRINDING NOISE", DateTime.Now.AddDays(7), MaintenanceCode.D3) },
      
      { 12, new MaintenanceTask(12, "NO. 5 WHEEL TYRE PRESSURE BLANK", DateTime.Now, MaintenanceCode.D3) },
      { 13, new MaintenanceTask(13, "IFE SCREEN 14A IN FLIGHT BRACKET", DateTime.Now.AddDays(34), MaintenanceCode.D3) },
      { 14, new MaintenanceTask(14, "L FLIGHT CREW BUNK SEAT FOOTST", DateTime.Now.AddDays(8), MaintenanceCode.D3) },
      { 15, new MaintenanceTask(15, "WREQ - GOGO KRFU REPLACEMENT - TBA", DateTime.Now.AddDays(-1), MaintenanceCode.D7) },
      
      { 16, new MaintenanceTask(16, "12A ELECTRICS DONT WORK", DateTime.Now.AddDays(14), MaintenanceCode.D3) },
      { 17, new MaintenanceTask(17, "TRANSFERRED FROM CABIN LOG HI", DateTime.Now.AddDays(-1), MaintenanceCode.D3) },
      { 18, new MaintenanceTask(18, "ERX-LIFE ITEM SMOKEHOOD CX NP", DateTime.Now.AddDays(5), MaintenanceCode.D7) },
      { 19, new MaintenanceTask(19, "CREW REPORT VIBRATING NOISE UNDER SEAT", DateTime.Now.AddDays(4), MaintenanceCode.D3) },
      { 20, new MaintenanceTask(20, "WEEKLY CHECK", DateTime.Now.AddDays(-4), MaintenanceCode.B7) },
      
      { 21, new MaintenanceTask(21, "STATUS MESG'S FUEL JETT PUMP L", DateTime.Now, MaintenanceCode.D3) },
      { 22, new MaintenanceTask(22, "STATUS MESG'S FUEL JETT PUMP R", DateTime.Now.AddDays(-1), MaintenanceCode.D3) },
      { 23, new MaintenanceTask(23, "FUEL SCAV SENSOR", DateTime.Now.AddDays(-1), MaintenanceCode.D3) },
      
      { 24, new MaintenanceTask(24, "OVERHEAD LOCKER CATCH ROW 12 L", DateTime.Now.AddDays(-2), MaintenanceCode.D3) },
      
      { 25, new MaintenanceTask(25, "WEEKLY CHECK", DateTime.Now.AddDays(2), MaintenanceCode.B7) },
    };

  public MaintenanceTask maintenanceTaskById(int id) =>
    allMaintenanceTasks()[id];
}
