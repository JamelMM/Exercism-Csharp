class RemoteControlCar
{
    private int speed = 0;
    private int batteryDrain = 0;
    private int distance = 0;
    private int battery = 100;
    
   
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        
    }

    public bool BatteryDrained()
    {
        if (battery < 1 || speed == 100 && batteryDrain > 50) {

            return true;
        }

        return false;
    }

    public int DistanceDriven() => distance;
    

    public void Drive()
    {

        if(battery >= batteryDrain){
            
            distance += speed;
            battery -= batteryDrain;
        }
        else{

            distance = distance;
        }
    }

    public static RemoteControlCar Nitro()
    {
         return new RemoteControlCar(50,4);
        
    }
}

class RaceTrack
{
    private int distance = 0;
   
    public RaceTrack(int distance){

        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        
        while(!car.BatteryDrained()){
        
            car.Drive();
            
            if ( car.DistanceDriven() >= distance){

                return true;
            }   
        }

        return false;        
    }   
}
