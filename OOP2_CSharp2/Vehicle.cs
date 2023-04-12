namespace OOP2_CSharp
{
    interface IVehicle
    {
        public void Speed();
        public void Fuel();
        public void Oil();
    }
    class Car : IVehicle
    {
        public void Fuel()
        {
            throw new System.NotImplementedException();
        }

        public void Oil()
        {
            throw new System.NotImplementedException();
        }

        public void Speed()
        {
            throw new System.NotImplementedException();
        }
    }
    class Velobike : IVehicle
    {
        public void Fuel()
        {
            throw new System.NotImplementedException();
        }

        public void Oil()
        {
            throw new System.NotImplementedException();
        }

        public void Speed()
        {
            throw new System.NotImplementedException();
        }
    }
    class Motor : IVehicle
    {
        public void Fuel()
        {
            throw new System.NotImplementedException();
        }

        public void Oil()
        {
            throw new System.NotImplementedException();
        }

        public void Speed()
        {
            throw new System.NotImplementedException();
        }
    }
}
