class RemoteControlCar
{
    private int meters = 0;
    private int batteryPercentage = 100;

    
    public static RemoteControlCar Buy()
    {
        RemoteControlCar car = new RemoteControlCar();
        return car;   
    } 

    public string DistanceDisplay()
    {
         if(batteryPercentage < 1)
        {
            
            return "Driven 2000 meters"; 
        }
        return $"Driven {meters} meters";
    }

    public string BatteryDisplay()
    {

        if(batteryPercentage < 1)
        {
            
            return $"Battery empty";
        }
        return $"Battery at {batteryPercentage}%";
    }

    public void Drive()
    {
        if (batteryPercentage > 0)
        {

            batteryPercentage--;
            meters += 20;
            DistanceDisplay(); 
        }
        
    }   
}
