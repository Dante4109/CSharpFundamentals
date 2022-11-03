using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFundies.DesignPatterns.SOLID
{

    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public DateTime Year { get; set; }


        private IVehicleRepository _vRepo;

        public Vehicle(IVehicleRepository vRepo)
        {
            _vRepo = vRepo;
        }
        public void Save()
        {
            _vRepo.AddVehicle(this);
        }

    }

    public interface IVehicleRepository
    {
        void AddVehicle(Vehicle v);
        void EditVehicle(Vehicle v);
        void DeleteVehicle(Vehicle v);


        IList<Vehicle> GetAllVehicles();


    }

    public class VehicleRepository : IVehicleRepository
    {


        public void AddVehicle(Vehicle v)
        {
            //code removed for clarity
        }

        public void DeleteVehicle(Vehicle v)
        {
            //code removed for clarity
        }

        public void EditVehicle(Vehicle v)
        {
            //code removed for clarity

        }

        public IList<Vehicle> GetAllVehicles()
        {

            IList<Vehicle> vehicleList = new List<Vehicle>();
            vehicleList.Add(new Vehicle(new VehicleRepository()) { Make = "Ford", Model = "F150", VehicleId = 1, Year = new DateTime(2022, 12, 20, 10, 20, 30) });
            //studentList.Add(new Student() { StudentId = 1, email = "FrankRush@School.com" });
            //code removed for clarity

            return vehicleList;
        }
    }
}
